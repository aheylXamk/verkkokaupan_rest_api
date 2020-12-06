-- phpMyAdmin SQL Dump
-- version 4.8.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: 06.12.2020 klo 20:48
-- Palvelimen versio: 10.1.37-MariaDB
-- PHP Version: 7.3.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `verkkokauppa`
--

-- --------------------------------------------------------

--
-- Rakenne taululle `tuotteet`
--

CREATE TABLE `tuotteet` (
  `Id` int(11) NOT NULL,
  `Vari` text COLLATE utf8_swedish_ci NOT NULL,
  `Koko` text COLLATE utf8_swedish_ci NOT NULL,
  `Hinta` decimal(10,2) NOT NULL,
  `Varastotilanne` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_swedish_ci;

--
-- Vedos taulusta `tuotteet`
--

INSERT INTO `tuotteet` (`Id`, `Vari`, `Koko`, `Hinta`, `Varastotilanne`) VALUES
(3, 'sininen', 'L', '9.90', 1),
(4, 'punainen', 'S', '9.90', 1),
(5, 'musta', 'M', '9.90', 1),
(6, 'harmaa', 'XL', '9.90', 5),
(7, 'sininen', 'XL', '9.90', 6),
(8, 'punainen', 'M', '9.90', 2),
(9, 'musta', 'S', '9.90', 3),
(11, 'valkoinen', 'XS', '9.90', 6);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tuotteet`
--
ALTER TABLE `tuotteet`
  ADD PRIMARY KEY (`Id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tuotteet`
--
ALTER TABLE `tuotteet`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
