CREATE DATABASE IF NOT EXISTS inventaris
    CHARACTER SET utf8mb4
    COLLATE utf8mb4_unicode_ci;

USE inventaris;

CREATE TABLE `BARANG` (
    `id_barang` INT UNSIGNED NOT NULL AUTO_INCREMENT PRIMARY KEY,
    `nama_barang` VARCHAR(50) NOT NULL,
    `jumlah_barang` INT NOT NULL,
    `nominal_harga` DECIMAL(10, 2) NOT NULL,
    `keadaan_barang` VARCHAR(50) NOT NULL
);

CREATE TABLE `USER` (
    `id_user` INT UNSIGNED NOT NULL AUTO_INCREMENT PRIMARY KEY,
    `nama_user` VARCHAR(100) NOT NULL,
    `username` VARCHAR(30) NOT NULL UNIQUE,
    `password` VARCHAR(255) NOT NULL,
    `role` VARCHAR(50) NOT NULL DEFAULT 'user'
);

CREATE TABLE `PEMINJAMAN` (
    `id_peminjaman` INT UNSIGNED NOT NULL AUTO_INCREMENT PRIMARY KEY,
    `id_user` INT UNSIGNED NOT NULL,
    `tanggal_pinjam` DATETIME NOT NULL,
    `rencana_kembali` DATETIME NOT NULL,
    `status_persetujuan` VARCHAR(30) NOT NULL DEFAULT 'menunggu',
    `id_pengurus_approve` INT UNSIGNED NULL,
    CONSTRAINT `peminjaman_id_user_foreign`
        FOREIGN KEY (`id_user`) REFERENCES `USER` (`id_user`),
    CONSTRAINT `peminjaman_id_pengurus_approve_foreign`
        FOREIGN KEY (`id_pengurus_approve`) REFERENCES `USER` (`id_user`)
);

CREATE TABLE `DETAIL_PEMINJAMAN` (
    `id_detail` INT UNSIGNED NOT NULL AUTO_INCREMENT PRIMARY KEY,
    `id_peminjaman` INT UNSIGNED NOT NULL,
    `id_barang` INT UNSIGNED NOT NULL,
    `jumlah_pinjam` INT NOT NULL,
    CONSTRAINT `detail_peminjaman_id_peminjaman_foreign`
        FOREIGN KEY (`id_peminjaman`) REFERENCES `PEMINJAMAN` (`id_peminjaman`),
    CONSTRAINT `detail_peminjaman_id_barang_foreign`
        FOREIGN KEY (`id_barang`) REFERENCES `BARANG` (`id_barang`)
);

CREATE TABLE `PENGEMBALIAN` (
    `id_pengembalian` INT UNSIGNED NOT NULL AUTO_INCREMENT PRIMARY KEY,
    `id_peminjaman` INT UNSIGNED NOT NULL,
    `tanggal_kembali` DATETIME NOT NULL,
    `kondisi_akhir` VARCHAR(50) NOT NULL,
    `id_penerima` INT UNSIGNED NOT NULL,
    CONSTRAINT `pengembalian_id_peminjaman_foreign`
        FOREIGN KEY (`id_peminjaman`) REFERENCES `PEMINJAMAN` (`id_peminjaman`),
    CONSTRAINT `pengembalian_id_penerima_foreign`
        FOREIGN KEY (`id_penerima`) REFERENCES `USER` (`id_user`)
);

CREATE TABLE `RENCANA_PEMBELIAN` (
    `id_rencana` INT UNSIGNED NOT NULL AUTO_INCREMENT PRIMARY KEY,
    `nama_barang` VARCHAR(100) NOT NULL,
    `estimasi_harga` DECIMAL(10, 2) NOT NULL,
    `status` VARCHAR(30) NOT NULL DEFAULT 'menunggu',
    `id_pengusul` INT UNSIGNED NOT NULL,
    CONSTRAINT `rencana_pembelian_id_pengusul_foreign`
        FOREIGN KEY (`id_pengusul`) REFERENCES `USER` (`id_user`)
);

ALTER TABLE `USER`
ADD CONSTRAINT `uq_user_username` UNIQUE (`username`);
