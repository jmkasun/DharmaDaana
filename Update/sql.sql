ALTER TABLE `mahameghadharmadaana`.`member` 
ADD COLUMN `numOfMagazine` INT NULL AFTER `bank`;

UPDATE `mahameghadharmadaana`.`member`  SET numOfMagazine = 0 WHERE ID > 0;

USE `mahameghadharmadaana`;
DROP procedure IF EXISTS `Member_Sel`;

ALTER TABLE `mahameghadharmadaana`.`payments` 
ADD COLUMN `extraAmount` INT NULL AFTER `addedDate`;

UPDATE payments SET extraAmount = 0 WHERE ID > 0;

DELIMITER $$
USE `mahameghadharmadaana`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `Member_Sel`(p_ID INT)
BEGIN

    
    SELECT `regNumber`,`name`,`address`,`mobileTP`,`homeTP`,`email`,`amount`,`paymentType`,`bank`,`subscriptionType`,nameInMag,numOfMagazine

    FROM member 
    
    WHERE ID = p_ID;
    
END$$


USE `mahameghadharmadaana`;
DROP procedure IF EXISTS `payments_Add`;

DELIMITER $$
USE `mahameghadharmadaana`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `payments_Add`(p_memberID INT, p_month DATE,P_amount INT,p_paidDate date,P_extraAmount INT)
BEGIN
    
    
    INSERT INTO payments(memberID, month, amount,paidDate,extraAmount,addedDate)
    VALUES(p_memberID, p_month, P_amount,p_paidDate,P_extraAmount,NOW());
        
    
END$$

DELIMITER ;

DELIMITER ;