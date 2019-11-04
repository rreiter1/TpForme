-- phpMyAdmin SQL Dump
-- version 4.8.4
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le :  lun. 04 nov. 2019 à 19:53
-- Version du serveur :  10.3.12-MariaDB
-- Version de PHP :  7.2.14

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données :  `tp_forme`
--

-- --------------------------------------------------------

--
-- Structure de la table `carre`
--

DROP TABLE IF EXISTS `carre`;
CREATE TABLE IF NOT EXISTS `carre` (
  `id_Carre` int(11) NOT NULL AUTO_INCREMENT,
  `Cote_Carre` int(11) NOT NULL,
  `X_Carre` int(11) NOT NULL,
  `Y_Carre` int(11) NOT NULL,
  PRIMARY KEY (`id_Carre`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 ROW_FORMAT=COMPACT;

--
-- Déchargement des données de la table `carre`
--

INSERT INTO `carre` (`id_Carre`, `Cote_Carre`, `X_Carre`, `Y_Carre`) VALUES
(1, 90, 169, 161);

-- --------------------------------------------------------

--
-- Structure de la table `cercle`
--

DROP TABLE IF EXISTS `cercle`;
CREATE TABLE IF NOT EXISTS `cercle` (
  `id_Cercle` int(11) NOT NULL AUTO_INCREMENT,
  `rayon` int(11) NOT NULL,
  `X_Cercle` int(11) NOT NULL,
  `Y_Cercle` int(11) NOT NULL,
  PRIMARY KEY (`id_Cercle`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Structure de la table `rectangle`
--

DROP TABLE IF EXISTS `rectangle`;
CREATE TABLE IF NOT EXISTS `rectangle` (
  `id_Rectangle` int(11) NOT NULL AUTO_INCREMENT,
  `longeur_Rectangle` int(11) NOT NULL,
  `largeur_Rectangle` int(11) NOT NULL,
  `X_Rectangle` int(11) NOT NULL,
  `Y_Rectangle` int(11) NOT NULL,
  PRIMARY KEY (`id_Rectangle`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
