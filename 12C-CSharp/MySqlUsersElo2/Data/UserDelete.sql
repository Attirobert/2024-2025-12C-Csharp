﻿DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `UserDelete`(IN `pID` INT(11))
DELETE FROM `users` WHERE `ID`=pID$$
DELIMITER ;