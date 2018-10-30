ALTER TABLE `mahameghadharmadaana`.`member` 
ADD COLUMN `numOfMagazine` INT NULL AFTER `bank`;


USE `mahameghadharmadaana`;
DROP procedure IF EXISTS `Member_Sel`;

DELIMITER $$
USE `mahameghadharmadaana`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `Member_Sel`(p_ID INT)
BEGIN

    
    SELECT `regNumber`,`name`,`address`,`mobileTP`,`homeTP`,`email`,`amount`,`paymentType`,`bank`,`subscriptionType`,nameInMag,numOfMagazine

    FROM member 
    
    WHERE ID = p_ID;
    
END$$

DELIMITER ;

