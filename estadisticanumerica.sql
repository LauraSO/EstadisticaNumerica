-- phpMyAdmin SQL Dump
-- version 5.1.0
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 22-10-2021 a las 17:57:53
-- Versión del servidor: 10.4.18-MariaDB
-- Versión de PHP: 8.0.3

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `estadisticanumerica`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `numeros`
--

CREATE TABLE `numeros` (
  `ID` int(11) NOT NULL,
  `Fecha` varchar(10) NOT NULL,
  `Numero` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `numeros`
--

INSERT INTO `numeros` (`ID`, `Fecha`, `Numero`) VALUES
(46, '01/09/2021', 1),
(47, '10/10/2021', 13),
(48, '19/10/2021', 55),
(49, '19/10/2021', 99),
(50, '04/10/2021', 55),
(51, '04/10/2021', 42),
(52, '04/10/2021', 66),
(53, '01/10/2021', 12),
(54, '21/10/2021', 55),
(55, '21/10/2021', 42);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `secuencias`
--

CREATE TABLE `secuencias` (
  `id` int(11) NOT NULL,
  `SecuenciaNumerica` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `secuencias`
--

INSERT INTO `secuencias` (`id`, `SecuenciaNumerica`) VALUES
(1, '94-49'),
(2, '93-48'),
(3, '92-47'),
(4, '91-46'),
(5, '90-45'),
(6, '89-44'),
(7, '98-43'),
(8, '97-42'),
(9, '96-41'),
(10, '95-40');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `numeros`
--
ALTER TABLE `numeros`
  ADD PRIMARY KEY (`ID`);

--
-- Indices de la tabla `secuencias`
--
ALTER TABLE `secuencias`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `numeros`
--
ALTER TABLE `numeros`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=56;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
