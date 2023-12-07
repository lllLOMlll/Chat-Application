-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Generation Time: Dec 07, 2023 at 12:35 PM
-- Server version: 8.0.31
-- PHP Version: 8.0.26

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `vp2_final_project`
--

-- --------------------------------------------------------

--
-- Table structure for table `posts`
--

DROP TABLE IF EXISTS `posts`;
CREATE TABLE IF NOT EXISTS `posts` (
  `post_id` int NOT NULL AUTO_INCREMENT,
  `user_id` int NOT NULL,
  `post` text NOT NULL,
  `time_published` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`post_id`),
  KEY `user_id` (`user_id`)
) ENGINE=MyISAM AUTO_INCREMENT=58 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Dumping data for table `posts`
--

INSERT INTO `posts` (`post_id`, `user_id`, `post`, `time_published`) VALUES
(56, 28, 'Send a message!', '2023-12-06 10:25:45'),
(57, 29, 'One message please!', '2023-12-06 10:27:44'),
(55, 23, 'First message!', '2023-12-06 10:22:52'),
(53, 27, 'I am Pink. Hello!', '2023-12-06 09:49:41'),
(52, 26, 'I am Orange. Hello!', '2023-12-06 09:49:07'),
(51, 25, 'I am Green. Hello!', '2023-12-06 09:48:36'),
(50, 24, 'I am Yellow. Hello!', '2023-12-06 09:47:57'),
(49, 23, 'I am Blue. Hello!', '2023-12-06 09:47:23');

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

DROP TABLE IF EXISTS `users`;
CREATE TABLE IF NOT EXISTS `users` (
  `user_id` int NOT NULL AUTO_INCREMENT,
  `username` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_as_cs NOT NULL,
  `first_name` varchar(255) DEFAULT NULL,
  `last_name` varchar(255) DEFAULT NULL,
  `dob` date DEFAULT NULL,
  `address` varchar(255) DEFAULT NULL,
  `telephone` varchar(20) DEFAULT NULL,
  `school` varchar(255) DEFAULT NULL,
  `program` varchar(255) DEFAULT NULL,
  `password` varchar(255) NOT NULL,
  `avatar` varchar(255) NOT NULL,
  `status` enum('active','inactive') NOT NULL DEFAULT 'active',
  PRIMARY KEY (`user_id`)
) ENGINE=MyISAM AUTO_INCREMENT=30 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`user_id`, `username`, `first_name`, `last_name`, `dob`, `address`, `telephone`, `school`, `program`, `password`, `avatar`, `status`) VALUES
(29, 'LOM', 'Louis', 'Olivier', '1999-04-04', '48 Thomas-Chapais, Montreal', '450-922-4444', 'Herzing', 'Analyst', 'e91347915e81731107c58a37b2dce7f230467f19faa945c7ad0f45453fd36589', 'C:\\Users\\louis\\source\\repos\\Visual Programming 2\\Final Project\\Open_Registration\\Resources\\aisan_yellow_ladie.jpg', 'active'),
(28, 'BigBlue', 'Louis', 'Major', '0001-01-01', '', '', '', '', 'e91347915e81731107c58a37b2dce7f230467f19faa945c7ad0f45453fd36589', 'C:\\Users\\louis\\source\\repos\\Visual Programming 2\\Final Project\\Open_Registration\\Resources\\orange_mustache_man.jpg', 'inactive'),
(27, 'Pink', NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'e91347915e81731107c58a37b2dce7f230467f19faa945c7ad0f45453fd36589', 'C:\\Users\\louis\\source\\repos\\Visual Programming 2\\Final Project\\Open_Registration\\Resources\\pink_something.jpg', 'active'),
(26, 'Orange', NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'e91347915e81731107c58a37b2dce7f230467f19faa945c7ad0f45453fd36589', 'C:\\Users\\louis\\source\\repos\\Visual Programming 2\\Final Project\\Open_Registration\\Resources\\orange_mustache_man.jpg', 'active'),
(24, 'Yellow', NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'e91347915e81731107c58a37b2dce7f230467f19faa945c7ad0f45453fd36589', 'C:\\Users\\louis\\source\\repos\\Visual Programming 2\\Final Project\\Open_Registration\\Resources\\aisan_yellow_ladie.jpg', 'active'),
(25, 'Green', NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'e91347915e81731107c58a37b2dce7f230467f19faa945c7ad0f45453fd36589', 'C:\\Users\\louis\\source\\repos\\Visual Programming 2\\Final Project\\Open_Registration\\Resources\\green_man_glass.jpg', 'active'),
(23, 'Blue', NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'e91347915e81731107c58a37b2dce7f230467f19faa945c7ad0f45453fd36589', 'C:\\Users\\louis\\source\\repos\\Visual Programming 2\\Final Project\\Open_Registration\\Resources\\blue_woman.jpg', 'active');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
