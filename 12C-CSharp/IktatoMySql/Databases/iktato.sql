-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2023. Nov 20. 17:42
-- Kiszolgáló verziója: 10.4.28-MariaDB
-- PHP verzió: 8.1.17

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Adatbázis: `iktato`
--

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `beosztasok`
--

CREATE TABLE `beosztasok` (
  `Id_Beosztas` int(11) NOT NULL,
  `Beosztas` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- A tábla adatainak kiíratása `beosztasok`
--

INSERT INTO `beosztasok` (`Id_Beosztas`, `Beosztas`) VALUES
(6, 'Árubeszerző         '),
(7, 'Belső ellenőr       '),
(5, 'Értékesítő          '),
(2, 'Főmérnök            '),
(1, 'Igazgató            '),
(8, 'Rakodó              '),
(10, 'Raktáros            '),
(9, 'Szalagvezető        ');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `iktat`
--

CREATE TABLE `iktat` (
  `Id_Iktat` int(11) NOT NULL,
  `Iktatoszam` varchar(20) NOT NULL,
  `IdUser` int(11) NOT NULL,
  `Datum` date NOT NULL,
  `IdTema` int(11) NOT NULL,
  `Leiras` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- A tábla adatainak kiíratása `iktat`
--

INSERT INTO `iktat` (`Id_Iktat`, `Iktatoszam`, `IdUser`, `Datum`, `IdTema`, `Leiras`) VALUES
(2, '458                 ', 3, '2023-10-25', 2, 'uvtft                                             '),
(3, '2023/014            ', 3, '2023-10-10', 2, 'iofrdzkj                                          '),
(4, '2023/015            ', 5, '2023-10-11', 1, 'iőhourcz u9z8 v7                                  '),
(5, '2023/016            ', 6, '2023-10-11', 1, 'nukguf uhuzz                                      '),
(6, '2023/017            ', 5, '2023-10-11', 1, 'hkhui                                             '),
(7, '20231010/1          ', 6, '2023-10-10', 4, 'iubvzd ftdfr                                      ');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `osztalyok`
--

CREATE TABLE `osztalyok` (
  `Id_Osztaly` int(11) NOT NULL,
  `Osztaly` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- A tábla adatainak kiíratása `osztalyok`
--

INSERT INTO `osztalyok` (`Id_Osztaly`, `Osztaly`) VALUES
(4, 'Beruházás           '),
(3, 'Beszerzés           '),
(2, 'Értékesítés         '),
(1, 'Igazgatóság         '),
(5, 'Kontrolling         '),
(6, 'Termelés            ');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `temak`
--

CREATE TABLE `temak` (
  `Id_Tema` int(11) NOT NULL,
  `Tema` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- A tábla adatainak kiíratása `temak`
--

INSERT INTO `temak` (`Id_Tema`, `Tema`) VALUES
(1, 'Beszerzés           '),
(2, 'Értékesítés         '),
(4, 'Raktározás          '),
(3, 'Ügyfél reklamációk  ');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `users`
--

CREATE TABLE `users` (
  `Id_User` int(11) NOT NULL,
  `Nev` varchar(20) NOT NULL,
  `Jelszo` varchar(20) NOT NULL,
  `Admin` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- A tábla adatainak kiíratása `users`
--

INSERT INTO `users` (`Id_User`, `Nev`, `Jelszo`, `Admin`) VALUES
(1, 'Attila              ', '1234      ', 1),
(3, 'Zsuzsa              ', '1234      ', 0),
(5, 'Alma                ', '1234      ', 0),
(6, 'Feri                ', '1234      ', 0),
(7, 'Ármin               ', '1234      ', 0),
(8, 'Zsolti              ', '1234      ', 0),
(9, 'Berci               ', '1234      ', 0),
(10, 'Zoli                ', '1234      ', 0),
(1008, 'Margó               ', '1234      ', 1);

--
-- Indexek a kiírt táblákhoz
--

--
-- A tábla indexei `beosztasok`
--
ALTER TABLE `beosztasok`
  ADD PRIMARY KEY (`Id_Beosztas`),
  ADD UNIQUE KEY `Beosztas` (`Beosztas`);

--
-- A tábla indexei `iktat`
--
ALTER TABLE `iktat`
  ADD PRIMARY KEY (`Id_Iktat`),
  ADD UNIQUE KEY `Iktatoszam` (`Iktatoszam`),
  ADD KEY `FK_iktat_users_Id_User` (`IdUser`),
  ADD KEY `FK_iktat_temak_Id_Tema` (`IdTema`);

--
-- A tábla indexei `osztalyok`
--
ALTER TABLE `osztalyok`
  ADD PRIMARY KEY (`Id_Osztaly`),
  ADD UNIQUE KEY `Osztaly` (`Osztaly`);

--
-- A tábla indexei `temak`
--
ALTER TABLE `temak`
  ADD PRIMARY KEY (`Id_Tema`),
  ADD UNIQUE KEY `Tema` (`Tema`);

--
-- A tábla indexei `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`Id_User`),
  ADD UNIQUE KEY `Nev` (`Nev`);

--
-- A kiírt táblák AUTO_INCREMENT értéke
--

--
-- AUTO_INCREMENT a táblához `beosztasok`
--
ALTER TABLE `beosztasok`
  MODIFY `Id_Beosztas` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT a táblához `iktat`
--
ALTER TABLE `iktat`
  MODIFY `Id_Iktat` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT a táblához `osztalyok`
--
ALTER TABLE `osztalyok`
  MODIFY `Id_Osztaly` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT a táblához `temak`
--
ALTER TABLE `temak`
  MODIFY `Id_Tema` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT a táblához `users`
--
ALTER TABLE `users`
  MODIFY `Id_User` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=1009;

--
-- Megkötések a kiírt táblákhoz
--

--
-- Megkötések a táblához `iktat`
--
ALTER TABLE `iktat`
  ADD CONSTRAINT `FK_iktat_temak_Id_Tema` FOREIGN KEY (`IdTema`) REFERENCES `temak` (`Id_Tema`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `FK_iktat_users_Id_User` FOREIGN KEY (`IdUser`) REFERENCES `users` (`Id_User`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
