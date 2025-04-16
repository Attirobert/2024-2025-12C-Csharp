DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `UserInsert`(IN `pNev` VARCHAR(20) CHARSET utf8mb4, IN `pJelszo` VARCHAR(10) CHARSET utf8mb4, IN `pAdmin` TINYINT(1))
INSERT INTO `users`(`Nev`, `Jelszo`, `Admin`) VALUES (pNev, pJelszo, pAdmin)$$
DELIMITER ;