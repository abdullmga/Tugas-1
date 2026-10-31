-- =========================================================
-- DATABASE INVENTARIS
-- =========================================================

CREATE DATABASE IF NOT EXISTS `inventaris`
    CHARACTER SET utf8mb4
    COLLATE utf8mb4_unicode_ci;

USE `inventaris`;

-- =========================================================
-- DDL - PEMBUATAN TABLE
-- =========================================================

-- =========================================================
-- TABLE BARANG
-- =========================================================

CREATE TABLE `BARANG` (
    `id_barang` INT UNSIGNED NOT NULL AUTO_INCREMENT,
    `nama_barang` VARCHAR(50) NOT NULL,
    `jumlah_barang` INT NOT NULL,
    `nominal_harga` DECIMAL(10, 2) NOT NULL,
    `keadaan_barang` VARCHAR(50) NOT NULL,

    PRIMARY KEY (`id_barang`)
) ENGINE=InnoDB;


-- =========================================================
-- TABLE USER
-- =========================================================

CREATE TABLE `USER` (
    `id_user` INT UNSIGNED NOT NULL AUTO_INCREMENT,
    `nama_user` VARCHAR(100) NOT NULL,
    `nisn` VARCHAR(10) NULL UNIQUE,
    `username` VARCHAR(30) NOT NULL,
    `password` VARCHAR(255) NOT NULL,
    `role` ENUM('siswa', 'pembina', 'pengurus')
        NOT NULL DEFAULT 'siswa',

    PRIMARY KEY (`id_user`),
    UNIQUE KEY `uk_user_username` (`username`)
) ENGINE=InnoDB;


-- =========================================================
-- TABLE PEMINJAMAN
-- =========================================================

CREATE TABLE `PEMINJAMAN` (
    `id_peminjaman` INT UNSIGNED NOT NULL AUTO_INCREMENT,
    `id_user` INT UNSIGNED NOT NULL,
    `tanggal_pinjam` DATETIME NOT NULL,
    `rencana_kembali` DATETIME NOT NULL,
    `status_persetujuan` VARCHAR(30) NOT NULL,
    `id_pengurus_approve` INT UNSIGNED NULL,

    PRIMARY KEY (`id_peminjaman`),

    CONSTRAINT `peminjaman_id_user_foreign`
        FOREIGN KEY (`id_user`)
        REFERENCES `USER` (`id_user`),

    CONSTRAINT `peminjaman_id_pengurus_approve_foreign`
        FOREIGN KEY (`id_pengurus_approve`)
        REFERENCES `USER` (`id_user`)
) ENGINE=InnoDB;


-- =========================================================
-- TABLE DETAIL PEMINJAMAN
-- =========================================================

CREATE TABLE `DETAIL_PEMINJAMAN` (
    `id_detail` INT UNSIGNED NOT NULL AUTO_INCREMENT,
    `id_peminjaman` INT UNSIGNED NOT NULL,
    `id_barang` INT UNSIGNED NOT NULL,
    `jumlah_pinjam` INT NOT NULL,

    PRIMARY KEY (`id_detail`),

    CONSTRAINT `detail_peminjaman_id_peminjaman_foreign`
        FOREIGN KEY (`id_peminjaman`)
        REFERENCES `PEMINJAMAN` (`id_peminjaman`),

    CONSTRAINT `detail_peminjaman_id_barang_foreign`
        FOREIGN KEY (`id_barang`)
        REFERENCES `BARANG` (`id_barang`)
) ENGINE=InnoDB;


-- =========================================================
-- TABLE PENGEMBALIAN
-- =========================================================

CREATE TABLE `PENGEMBALIAN` (
    `id_pengembalian` INT UNSIGNED NOT NULL AUTO_INCREMENT,
    `id_peminjaman` INT UNSIGNED NOT NULL,
    `tanggal_kembali` DATETIME NOT NULL,
    `kondisi_akhir` VARCHAR(50) NOT NULL,
    `id_penerima` INT UNSIGNED NOT NULL,

    PRIMARY KEY (`id_pengembalian`),

    CONSTRAINT `pengembalian_id_peminjaman_foreign`
        FOREIGN KEY (`id_peminjaman`)
        REFERENCES `PEMINJAMAN` (`id_peminjaman`),

    CONSTRAINT `pengembalian_id_penerima_foreign`
        FOREIGN KEY (`id_penerima`)
        REFERENCES `USER` (`id_user`)
) ENGINE=InnoDB;


-- =========================================================
-- TABLE RENCANA PEMBELIAN
-- =========================================================

CREATE TABLE `RENCANA_PEMBELIAN` (
    `id_rencana` INT UNSIGNED NOT NULL AUTO_INCREMENT,
    `nama_barang` VARCHAR(100) NOT NULL,
    `estimasi_harga` DECIMAL(10, 2) NOT NULL,
    `status` VARCHAR(30) NOT NULL,
    `id_pengusul` INT UNSIGNED NOT NULL,

    PRIMARY KEY (`id_rencana`),

    CONSTRAINT `rencana_pembelian_id_pengusul_foreign`
        FOREIGN KEY (`id_pengusul`)
        REFERENCES `USER` (`id_user`)
) ENGINE=InnoDB;


-- =========================================================
-- DML - USER
-- =========================================================

-- REGISTER
INSERT INTO `USER`
(
    `nama_user`,
    `nisn`,
    `username`,
    `password`,
    `role`
)
VALUES
(
    @nama_user,
    @nisn,
    @username,
    @password,
    @role
);


-- LOGIN
SELECT
    `id_user`,
    `nama_user`,
    `role`
FROM `USER`
WHERE `username` = @username;


-- MENAMPILKAN USER
SELECT
    `id_user`,
    `nama_user`,
    `nisn`,
    `username`,
    `role`
FROM `USER`;


-- =========================================================
-- DML - BARANG
-- =========================================================

-- MENAMPILKAN BARANG
SELECT
    `id_barang`,
    `nama_barang`,
    `jumlah_barang`,
    `nominal_harga`,
    `keadaan_barang`
FROM `BARANG`;


-- TAMBAH BARANG
INSERT INTO `BARANG`
(
    `nama_barang`,
    `jumlah_barang`,
    `nominal_harga`,
    `keadaan_barang`
)
VALUES
(
    @nama_barang,
    @jumlah_barang,
    @nominal_harga,
    @keadaan_barang
);


-- UPDATE BARANG
UPDATE `BARANG`
SET
    `nama_barang` = @nama_barang,
    `jumlah_barang` = @jumlah_barang,
    `nominal_harga` = @nominal_harga,
    `keadaan_barang` = @keadaan_barang
WHERE `id_barang` = @id_barang;


-- DELETE BARANG
DELETE FROM `BARANG`
WHERE `id_barang` = @id_barang;


-- CARI BARANG
SELECT
    `id_barang`,
    `nama_barang`,
    `jumlah_barang`,
    `nominal_harga`,
    `keadaan_barang`
FROM `BARANG`
WHERE `nama_barang` LIKE @keyword;


-- =========================================================
-- DML - PEMINJAMAN
-- =========================================================

-- TAMBAH PEMINJAMAN
INSERT INTO `PEMINJAMAN`
(
    `id_user`,
    `tanggal_pinjam`,
    `rencana_kembali`,
    `status_persetujuan`,
    `id_pengurus_approve`
)
VALUES
(
    @id_user,
    @tanggal_pinjam,
    @rencana_kembali,
    @status_persetujuan,
    @id_pengurus_approve
);


-- PEMINJAMAN MILIK USER
SELECT
    `id_peminjaman`,
    `id_user`,
    `tanggal_pinjam`,
    `rencana_kembali`,
    `status_persetujuan`,
    `id_pengurus_approve`
FROM `PEMINJAMAN`
WHERE `id_user` = @id_user;


-- SEMUA PEMINJAMAN
SELECT
    `id_peminjaman`,
    `id_user`,
    `tanggal_pinjam`,
    `rencana_kembali`,
    `status_persetujuan`,
    `id_pengurus_approve`
FROM `PEMINJAMAN`;


-- UPDATE STATUS PEMINJAMAN
UPDATE `PEMINJAMAN`
SET
    `status_persetujuan` = @status_persetujuan,
    `id_pengurus_approve` = @id_pengurus_approve
WHERE `id_peminjaman` = @id_peminjaman;


-- =========================================================
-- DML - DETAIL PEMINJAMAN
-- =========================================================

-- TAMBAH DETAIL PEMINJAMAN
INSERT INTO `DETAIL_PEMINJAMAN`
(
    `id_peminjaman`,
    `id_barang`,
    `jumlah_pinjam`
)
VALUES
(
    @id_peminjaman,
    @id_barang,
    @jumlah_pinjam
);


-- LIHAT DETAIL PEMINJAMAN
SELECT
    `id_detail`,
    `id_peminjaman`,
    `id_barang`,
    `jumlah_pinjam`
FROM `DETAIL_PEMINJAMAN`
WHERE `id_peminjaman` = @id_peminjaman;


-- =========================================================
-- DML - PENGEMBALIAN
-- =========================================================

-- TAMBAH PENGEMBALIAN
INSERT INTO `PENGEMBALIAN`
(
    `id_peminjaman`,
    `tanggal_kembali`,
    `kondisi_akhir`,
    `id_penerima`
)
VALUES
(
    @id_peminjaman,
    @tanggal_kembali,
    @kondisi_akhir,
    @id_penerima
);


-- LIHAT PENGEMBALIAN
SELECT
    `id_pengembalian`,
    `id_peminjaman`,
    `tanggal_kembali`,
    `kondisi_akhir`,
    `id_penerima`
FROM `PENGEMBALIAN`;


-- =========================================================
-- DML - RENCANA PEMBELIAN
-- =========================================================

-- TAMBAH RENCANA PEMBELIAN
INSERT INTO `RENCANA_PEMBELIAN`
(
    `nama_barang`,
    `estimasi_harga`,
    `status`,
    `id_pengusul`
)
VALUES
(
    @nama_barang,
    @estimasi_harga,
    @status,
    @id_pengusul
);


-- RENCANA PEMBELIAN MILIK USER
SELECT
    `id_rencana`,
    `nama_barang`,
    `estimasi_harga`,
    `status`,
    `id_pengusul`
FROM `RENCANA_PEMBELIAN`
WHERE `id_pengusul` = @id_pengusul;


-- SEMUA RENCANA PEMBELIAN
SELECT
    `id_rencana`,
    `nama_barang`,
    `estimasi_harga`,
    `status`,
    `id_pengusul`
FROM `RENCANA_PEMBELIAN`;


-- UPDATE STATUS RENCANA PEMBELIAN
UPDATE `RENCANA_PEMBELIAN`
SET
    `status` = @status
WHERE `id_rencana` = @id_rencana;


-- =========================================================
-- DATA TEST
-- =========================================================

INSERT INTO `USER`
(
    `nama_user`,
    `username`,
    `password`,
    `role`
)
VALUES
(
    'Oliver Queen',
    'oli',
    '123',
    'pengurus'
);


INSERT INTO `USER`
(
    `nama_user`,
    `username`,
    `password`,
    `role`
)
VALUES
(
    'Mr.Junior',
    'junior',
    '123',
    'pembina'
);


-- =========================================================
-- DEBUG / CEK DATA
-- =========================================================

DESCRIBE `USER`;

SELECT * FROM `USER`;

SELECT * FROM `BARANG`;

SELECT * FROM `PEMINJAMAN`;

SELECT * FROM `DETAIL_PEMINJAMAN`;

SELECT * FROM `PENGEMBALIAN`;

SELECT * FROM `RENCANA_PEMBELIAN`;

-- =========================================================
-- MENAMBAHKAN ROLE PENGURUS/PEMBINA
-- =========================================================

INSERT INTO `user` (nama_user, username, password, role)
VALUES 
('Ahmed Subarjo', 'ahmad', '$2a$12$5mVZ43I9ZUyaAzNKJZVQueQ565YKs9SPdltBhdxUawFuuYwyZ/Ehy', 'pengurus');

-- https://bcrypt-generator.com/
-- link untuk generate hash bcrypt password

INSERT INTO `user` (nama_user, username, password, role)
VALUES 
('Hamud Bin Khaled', 'hamud', '$2a$12$hyJ5oLtOXMRhzJ4gHWwFNOKMoDxIEAMPufxjJtJ1vKNFg4Krlzm9i', 'pembina');
