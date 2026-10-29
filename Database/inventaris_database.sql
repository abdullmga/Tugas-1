-- =========================================================
-- MEMBUAT - DATABASE
-- =========================================================
CREATE DATABASE IF NOT EXISTS inventaris
    CHARACTER SET utf8mb4
    COLLATE utf8mb4_unicode_ci;

USE inventaris;

-- =========================================================
-- DDL - PEMBUATAN TABLE
-- =========================================================

CREATE TABLE `BARANG`(
    `id_barang` INT UNSIGNED NOT NULL AUTO_INCREMENT PRIMARY KEY,
    `nama_barang` VARCHAR(50) NOT NULL,
    `jumlah_barang` INT NOT NULL,
    `nominal_harga` DECIMAL(10, 2) NOT NULL,
    `keadaan_barang` VARCHAR(50) NOT NULL
);

CREATE TABLE `USER`(
    `id_user` INT UNSIGNED NOT NULL AUTO_INCREMENT PRIMARY KEY,
    `nama_user` VARCHAR(100) NOT NULL,
    `username` VARCHAR(30) NOT NULL,
    `password` VARCHAR(10) NOT NULL,
    `role` ENUM('siswa', 'pembina', 'pengurus') NOT NULL DEFAULT 'siswa'
);

CREATE TABLE `PEMINJAMAN`(
    `id_peminjaman` INT UNSIGNED NOT NULL AUTO_INCREMENT PRIMARY KEY,
    `id_user` INT NOT NULL,
    `tanggal_pinjam` DATETIME NOT NULL,
    `rencana_kembali` DATETIME NOT NULL,
    `status_persetujuan` VARCHAR(30) NOT NULL,
    `id_pengurus_approve` INT NOT NULL
);

CREATE TABLE `DETAIL_PEMINJAMAN`(
    `id_detail` INT UNSIGNED NOT NULL AUTO_INCREMENT PRIMARY KEY,
    `id_peminjaman` INT NOT NULL,
    `id_barang` INT NOT NULL,
    `jumlah_pinjam` INT NOT NULL
);

CREATE TABLE `PENGEMBALIAN`(
    `id_pengembalian` INT UNSIGNED NOT NULL AUTO_INCREMENT PRIMARY KEY,
    `id_peminjaman` INT NOT NULL,
    `tanggal_kembali` DATETIME NOT NULL,
    `kondisi_akhir` VARCHAR(50) NOT NULL,
    `id_penerima` INT NOT NULL
);

CREATE TABLE `RENCANA_PEMBELIAN`(
    `id_rencana` INT UNSIGNED NOT NULL AUTO_INCREMENT PRIMARY KEY,
    `nama_barang` VARCHAR(100) NOT NULL,
    `estimasi_harga` DECIMAL(10, 2) NOT NULL,
    `status` VARCHAR(30) NOT NULL,
    `id_pengusul` INT NOT NULL
);


-- =========================================================
-- DDL - FOREIGN KEY
-- =========================================================

ALTER TABLE
    `DETAIL_PEMINJAMAN`
ADD CONSTRAINT `detail_peminjaman_id_barang_foreign`
FOREIGN KEY(`id_barang`) REFERENCES `BARANG`(`id_barang`);

ALTER TABLE
    `PENGEMBALIAN`
ADD CONSTRAINT `pengembalian_id_peminjaman_foreign`
FOREIGN KEY(`id_peminjaman`) REFERENCES `PEMINJAMAN`(`id_peminjaman`);

ALTER TABLE
    `PENGEMBALIAN`
ADD CONSTRAINT `pengembalian_id_penerima_foreign`
FOREIGN KEY(`id_penerima`) REFERENCES `USER`(`id_user`);

ALTER TABLE
    `PEMINJAMAN`
ADD CONSTRAINT `peminjaman_id_user_foreign`
FOREIGN KEY(`id_user`) REFERENCES `USER`(`id_user`);

ALTER TABLE
    `DETAIL_PEMINJAMAN`
ADD CONSTRAINT `detail_peminjaman_id_peminjaman_foreign`
FOREIGN KEY(`id_peminjaman`) REFERENCES `PEMINJAMAN`(`id_peminjaman`);

ALTER TABLE
    `RENCANA_PEMBELIAN`
ADD CONSTRAINT `rencana_pembelian_id_pengusul_foreign`
FOREIGN KEY(`id_pengusul`) REFERENCES `USER`(`id_user`);

ALTER TABLE
    `PEMINJAMAN`
ADD CONSTRAINT `peminjaman_id_pengurus_approve_foreign`
FOREIGN KEY(`id_pengurus_approve`) REFERENCES `USER`(`id_user`);


-- =========================================================
-- DML - USER
-- =========================================================

-- Register / tambah akun baru
INSERT INTO `USER`
(`nama_user`, `username`, `password`, `role`)
VALUES
(@nama_user, @username, @password, @role);


-- Login user
SELECT
    `id_user`,
    `nama_user`,
    `role`
FROM `USER`
WHERE `username` = @username
AND `password` = @password;


-- Menampilkan seluruh user
SELECT
    `id_user`,
    `nama_user`,
    `username`,
    `role`
FROM `USER`;


-- =========================================================
-- DML - BARANG
-- =========================================================

-- Menampilkan seluruh barang / katalog
SELECT
    `id_barang`,
    `nama_barang`,
    `jumlah_barang`,
    `nominal_harga`,
    `keadaan_barang`
FROM `BARANG`;


-- Menambahkan barang baru
INSERT INTO `BARANG`
(`nama_barang`, `jumlah_barang`, `nominal_harga`, `keadaan_barang`)
VALUES
(@nama_barang, @jumlah_barang, @nominal_harga, @keadaan_barang);


-- Mengubah data barang
UPDATE `BARANG`
SET
    `nama_barang` = @nama_barang,
    `jumlah_barang` = @jumlah_barang,
    `nominal_harga` = @nominal_harga,
    `keadaan_barang` = @keadaan_barang
WHERE `id_barang` = @id_barang;


-- Menghapus barang
DELETE FROM `BARANG`
WHERE `id_barang` = @id_barang;


-- Mencari barang berdasarkan nama
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

-- Membuat pengajuan peminjaman
INSERT INTO `PEMINJAMAN`
(`id_user`, `tanggal_pinjam`, `rencana_kembali`,
 `status_persetujuan`, `id_pengurus_approve`)
VALUES
(@id_user, @tanggal_pinjam, @rencana_kembali,
 @status_persetujuan, @id_pengurus_approve);


-- Menampilkan data peminjaman milik user
SELECT
    `id_peminjaman`,
    `id_user`,
    `tanggal_pinjam`,
    `rencana_kembali`,
    `status_persetujuan`,
    `id_pengurus_approve`
FROM `PEMINJAMAN`
WHERE `id_user` = @id_user;


-- Menampilkan seluruh peminjaman
SELECT
    `id_peminjaman`,
    `id_user`,
    `tanggal_pinjam`,
    `rencana_kembali`,
    `status_persetujuan`,
    `id_pengurus_approve`
FROM `PEMINJAMAN`;


-- Mengubah status persetujuan peminjaman
UPDATE `PEMINJAMAN`
SET
    `status_persetujuan` = @status_persetujuan,
    `id_pengurus_approve` = @id_pengurus_approve
WHERE `id_peminjaman` = @id_peminjaman;


-- =========================================================
-- DML - DETAIL PEMINJAMAN
-- =========================================================

-- Menambahkan barang ke dalam peminjaman
INSERT INTO `DETAIL_PEMINJAMAN`
(`id_peminjaman`, `id_barang`, `jumlah_pinjam`)
VALUES
(@id_peminjaman, @id_barang, @jumlah_pinjam);


-- Menampilkan detail barang yang dipinjam
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

-- Mencatat pengembalian barang
INSERT INTO `PENGEMBALIAN`
(`id_peminjaman`, `tanggal_kembali`,
 `kondisi_akhir`, `id_penerima`)
VALUES
(@id_peminjaman, @tanggal_kembali,
 @kondisi_akhir, @id_penerima);


-- Menampilkan data pengembalian
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

-- Membuat pengajuan rencana pembelian
INSERT INTO `RENCANA_PEMBELIAN`
(`nama_barang`, `estimasi_harga`, `status`, `id_pengusul`)
VALUES
(@nama_barang, @estimasi_harga, @status, @id_pengusul);


-- Menampilkan rencana pembelian milik user
SELECT
    `id_rencana`,
    `nama_barang`,
    `estimasi_harga`,
    `status`,
    `id_pengusul`
FROM `RENCANA_PEMBELIAN`
WHERE `id_pengusul` = @id_pengusul;


-- Menampilkan seluruh rencana pembelian
SELECT
    `id_rencana`,
    `nama_barang`,
    `estimasi_harga`,
    `status`,
    `id_pengusul`
FROM `RENCANA_PEMBELIAN`;


-- Mengubah status rencana pembelian
UPDATE `RENCANA_PEMBELIAN`
SET
    `status` = @status
WHERE `id_rencana` = @id_rencana;

