DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `UserUpdate`(IN `pID` INT(11), IN `pJelszo` VARCHAR(10) CHARSET utf8mb4, IN `pNev` VARCHAR(20) CHARSET utf8mb4, IN `pAdmin` TINYINT(1))
UPDATE `users` SET `Nev`=pNev, `Jelszo`=pJelszo, `Admin`=pAdmin WHERE `ID`=pID$$
DELIMITER ;