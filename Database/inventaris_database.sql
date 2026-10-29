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
    `username` VARCHAR(30) NOT NULL,
    `password` VARCHAR(10) NOT NULL,
    `role` ENUM('siswa', 'pembina', 'pengurus') NOT NULL DEFAULT 'siswa',

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
-- REGISTER / TAMBAH AKUN BARU
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
    @nama_user,
    @username,
    @password,
    @role
);


-- =========================================================
-- LOGIN USER
-- =========================================================

SELECT
    `id_user`,
    `nama_user`,
    `role`
FROM `USER`
WHERE `username` = @username
AND `password` = @password;


-- =========================================================
-- MENAMPILKAN SELURUH USER
-- =========================================================

SELECT
    `id_user`,
    `nama_user`,
    `username`,
    `role`
FROM `USER`;


-- =========================================================
-- DML - BARANG
-- =========================================================


-- =========================================================
-- MENAMPILKAN SELURUH BARANG / KATALOG
-- =========================================================

SELECT
    `id_barang`,
    `nama_barang`,
    `jumlah_barang`,
    `nominal_harga`,
    `keadaan_barang`
FROM `BARANG`;


-- =========================================================
-- MENAMBAHKAN BARANG BARU
-- =========================================================

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


-- =========================================================
-- MENGUBAH DATA BARANG
-- =========================================================

UPDATE `BARANG`
SET
    `nama_barang` = @nama_barang,
    `jumlah_barang` = @jumlah_barang,
    `nominal_harga` = @nominal_harga,
    `keadaan_barang` = @keadaan_barang
WHERE `id_barang` = @id_barang;


-- =========================================================
-- MENGHAPUS BARANG
-- =========================================================

DELETE FROM `BARANG`
WHERE `id_barang` = @id_barang;


-- =========================================================
-- MENCARI BARANG BERDASARKAN NAMA
-- =========================================================

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


-- =========================================================
-- MEMBUAT PENGAJUAN PEMINJAMAN
-- =========================================================

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


-- =========================================================
-- MENAMPILKAN PEMINJAMAN MILIK USER
-- =========================================================

SELECT
    `id_peminjaman`,
    `id_user`,
    `tanggal_pinjam`,
    `rencana_kembali`,
    `status_persetujuan`,
    `id_pengurus_approve`
FROM `PEMINJAMAN`
WHERE `id_user` = @id_user;


-- =========================================================
-- MENAMPILKAN SELURUH PEMINJAMAN
-- =========================================================

SELECT
    `id_peminjaman`,
    `id_user`,
    `tanggal_pinjam`,
    `rencana_kembali`,
    `status_persetujuan`,
    `id_pengurus_approve`
FROM `PEMINJAMAN`;


-- =========================================================
-- MENGUBAH STATUS PERSETUJUAN PEMINJAMAN
-- =========================================================

UPDATE `PEMINJAMAN`
SET
    `status_persetujuan` = @status_persetujuan,
    `id_pengurus_approve` = @id_pengurus_approve
WHERE `id_peminjaman` = @id_peminjaman;


-- =========================================================
-- DML - DETAIL PEMINJAMAN
-- =========================================================


-- =========================================================
-- MENAMBAHKAN BARANG KE PEMINJAMAN
-- =========================================================

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


-- =========================================================
-- MENAMPILKAN DETAIL BARANG YANG DIPINJAM
-- =========================================================

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


-- =========================================================
-- MENCATAT PENGEMBALIAN BARANG
-- =========================================================

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


-- =========================================================
-- MENAMPILKAN DATA PENGEMBALIAN
-- =========================================================

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


-- =========================================================
-- MEMBUAT PENGAJUAN RENCANA PEMBELIAN
-- =========================================================

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


-- =========================================================
-- MENAMPILKAN RENCANA PEMBELIAN MILIK USER
-- =========================================================

SELECT
    `id_rencana`,
    `nama_barang`,
    `estimasi_harga`,
    `status`,
    `id_pengusul`
FROM `RENCANA_PEMBELIAN`
WHERE `id_pengusul` = @id_pengusul;


-- =========================================================
-- MENAMPILKAN SELURUH RENCANA PEMBELIAN
-- =========================================================

SELECT
    `id_rencana`,
    `nama_barang`,
    `estimasi_harga`,
    `status`,
    `id_pengusul`
FROM `RENCANA_PEMBELIAN`;


-- =========================================================
-- MENGUBAH STATUS RENCANA PEMBELIAN
-- =========================================================

UPDATE `RENCANA_PEMBELIAN`
SET
    `status` = @status
WHERE `id_rencana` = @id_rencana;



insert into `user`(nama_user, username, password, `role`) VALUES ('Muhammad', 'mhd', '123', 'pengurus');

ALTER TABLE `USER`
MODIFY COLUMN `role`
ENUM('siswa', 'pembina', 'pengurus')
NOT NULL DEFAULT 'siswa';

desc user; 

delete from `user` where role = "";


insert into `user`(nama_user, username, password, `role`) VALUES ('Chloe Sullivan', 'chole', '123', 'pembina');


update `user` set username = 'chloe' where `role` = 'pembina';