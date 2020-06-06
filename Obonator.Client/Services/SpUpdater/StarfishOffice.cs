using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Obonator.Client.Services.SpUpdater
{
    public static class StarfishOffice
    {
        public static string StarfishOfficeSpExample()
        {
           string inputData = @"USE [starfish_office_dev]
GO
/****** Object:  StoredProcedure [dbo].[uspStatisticMultiBiller_Cabang]    Script Date: 2/13/2020 1:58:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*
This software, all associated documentation, and all copies are CONFIDENTIAL INFORMATION of PT. Arranet Indonesia Sejahtera.

Created By    	: Rully
Create Date 	: 2019-10-20
Description   	: Statistic Multibiller LEVEL CABANG
Revised By    	:

Date			User				Note
-----------------------------------------------------------------------------------------------------------------------
2020-02-11      Reza                Tambah PDAM Medan
End Revised
*/

--[uspStatisticMultiBiller_Cabang] '20180905'
--GO
--[uspStatisticMultiBiller_Cabang] '20180906'
--GO
--[uspStatisticMultiBiller_Cabang] '20180907'
--GO
--[uspStatisticMultiBiller_Cabang] '20180909'

ALTER PROCEDURE [dbo].[uspStatisticMultiBiller_Cabang]
(
@transaction_date VARCHAR(20)
)
AS
BEGIN
--interfering with SELECT statements.
SET NOCOUNT ON;

;with cteData as
(
SELECT
tt.branch_id,
tt.branch_name,
tt.collecting_agent_id,
tt.collecting_agent_name,
tt.biller_id,
tt.transaction_id,
tt.amount AS rupiah,
tt.admin_fee AS komisi,
tt.date_iso as date_iso,
tt.create_by,
COUNT(distinct tt.create_by) loket_aktif,
CONVERT(date, tt.create_date) transaction_date,
(CASE tt.biller_id WHEN 40001
THEN sum(CONVERT(INT, CASE WHEN IsNumeric(CONVERT(VARCHAR(12), SUBSTRING(private_data_48,20,1))) = 1 THEN
CONVERT(VARCHAR(12), SUBSTRING(private_data_48,20,1)) ELSE 0 End)) ELSE FORMAT(COUNT(tt.biller_id),'N0') END
) AS jumlah
FROM office_transaction tt with (nolock)
WHERE
CONVERT(VARCHAR(8), tt.create_date, 112) = @transaction_date
AND
tt.is_success = 1
GROUP BY
tt.biller_id, tt.transaction_id, tt.amount, tt.admin_fee, tt.date_iso, tt.biller_id,
tt.branch_id,  tt.branch_name,  tt.collecting_agent_id, tt.collecting_agent_name,tt.create_by,
CONVERT(date, tt.create_date)
)

SELECT
T2.transaction_date,
T2.loket_aktif as loket_aktif,
T2.branch_id,
T2.branch_name,
T2.collecting_agent_id,
T2.collecting_agent_name,

-- ALL PLN --
T2.PLN_POSTPAID_JUMLAH,
T2.PLN_POSTPAID_RUPIAH,
T2.PLN_POSTPAID_KOMISI,
T2.PLN_POSTPAID_TOTAL,

T2.PLN_PREPAID_JUMLAH,
T2.PLN_PREPAID_RUPIAH,
T2.PLN_PREPAID_KOMISI,
PLN_PREPAID_TOTAL,

T2.PLN_NONTAGLIS_JUMLAH,
T2.PLN_NONTAGLIS_RUPIAH,
T2.PLN_NONTAGLIS_KOMISI,
T2.PLN_NONTAGLIS_TOTAL,

T2.PLN_JUMLAH,
T2.PLN_RUPIAH,
T2.PLN_KOMISI,
(T2.PLN_RUPIAH + T2.PLN_KOMISI) AS PLN_TOTAL,

-- END PLN --



----PDAM Medan
T2.PDAM_MEDAN_JUMLAH,
T2.PDAM_MEDAN_RUPIAH,
T2.PDAM_MEDAN_KOMISI,
T2.PDAM_MEDAN_TOTAL,
----END OF PDAM Medan
-- END OF GENERATOR ONE --

T2.NON_PLN_JUMLAH,
T2.NON_PLN_RUPIAH,
T2.NON_PLN_KOMISI,
(T2.NON_PLN_RUPIAH + T2.NON_PLN_KOMISI) AS NON_PLN_TOTAL,

(T2.PLN_JUMLAH + T2.NON_PLN_JUMLAH) AS SUM_JUMLAH,
(T2.PLN_RUPIAH + T2.NON_PLN_RUPIAH) AS SUM_RUPIAH,
(T2.PLN_KOMISI + T2.NON_PLN_KOMISI) AS SUM_KOMISI,
(T2.PLN_RUPIAH + T2.PLN_KOMISI + T2.NON_PLN_RUPIAH + T2.NON_PLN_KOMISI) AS SUM_TOTAL
FROM
(
SELECT
T.transaction_date,
T.loket_aktif as loket_aktif,
T.branch_id,
T.branch_name,
T.collecting_agent_id,
T.collecting_agent_name,

-- ALL PLN --
T.PLN_POSTPAID_JUMLAH,
T.PLN_POSTPAID_RUPIAH,
T.PLN_POSTPAID_KOMISI,
(T.PLN_POSTPAID_RUPIAH + T.PLN_POSTPAID_KOMISI) AS PLN_POSTPAID_TOTAL,

T.PLN_PREPAID_JUMLAH,
T.PLN_PREPAID_RUPIAH,
T.PLN_PREPAID_KOMISI,
(T.PLN_PREPAID_RUPIAH + T.PLN_PREPAID_KOMISI) AS PLN_PREPAID_TOTAL,

T.PLN_NONTAGLIS_JUMLAH,
T.PLN_NONTAGLIS_RUPIAH,
T.PLN_NONTAGLIS_KOMISI,
(T.PLN_NONTAGLIS_RUPIAH + T.PLN_NONTAGLIS_KOMISI) AS PLN_NONTAGLIS_TOTAL,

(T.PLN_POSTPAID_JUMLAH + T.PLN_PREPAID_JUMLAH + T.PLN_NONTAGLIS_JUMLAH) AS PLN_JUMLAH,
(T.PLN_POSTPAID_RUPIAH + T.PLN_PREPAID_RUPIAH + T.PLN_NONTAGLIS_RUPIAH) AS PLN_RUPIAH,
(T.PLN_POSTPAID_KOMISI + T.PLN_PREPAID_KOMISI + T.PLN_NONTAGLIS_KOMISI) AS PLN_KOMISI,


-- PDAM Medan --
T.PDAM_MEDAN_JUMLAH,
T.PDAM_MEDAN_RUPIAH,
T.PDAM_MEDAN_KOMISI,
(T.PDAM_MEDAN_RUPIAH + T.PDAM_MEDAN_KOMISI) AS PDAM_MEDAN_TOTAL,
-- END OF PDAM Medan
-- END OF GENERATOR TWO --

-- ALL SUMMARY NON PLN --
(
-- PDAM Medan --
+ T.PDAM_MEDAN_JUMLAH
-- END OF PDAM Medan
-- END OF GENERATOR THREE --

) AS NON_PLN_JUMLAH,
(

-- PDAM Medan --
+ T.PDAM_MEDAN_RUPIAH
-- END OF PDAM Medan
-- END OF GENERATOR FOUR --

) AS NON_PLN_RUPIAH,
(

-- PDAM Medan --
+ T.PDAM_MEDAN_KOMISI
-- END OF PDAM Medan
-- END OF GENERATOR FIVE --

) AS NON_PLN_KOMISI
-- END OF SUMMARY NON PLN --
FROM
(
SELECT
tt.transaction_date,
count(distinct tt.create_by) loket_aktif,
tt.branch_id,
tt.branch_name,
tt.collecting_agent_id,
tt.collecting_agent_name,
-- ALL PLN --
ISNULL(SUM(PLN_POSTPAID.JUMLAH),0) AS PLN_POSTPAID_JUMLAH,
ISNULL(SUM(PLN_POSTPAID.RUPIAH),0) AS PLN_POSTPAID_RUPIAH,
ISNULL(SUM(PLN_POSTPAID.KOMISI),0) AS PLN_POSTPAID_KOMISI,
ISNULL(SUM(PLN_PREPAID.JUMLAH),0) AS PLN_PREPAID_JUMLAH,
ISNULL(SUM(PLN_PREPAID.RUPIAH),0) AS PLN_PREPAID_RUPIAH,
ISNULL(SUM(PLN_PREPAID.KOMISI),0) AS PLN_PREPAID_KOMISI,
ISNULL(SUM(PLN_NONTAGLIS.JUMLAH),0) AS PLN_NONTAGLIS_JUMLAH,
ISNULL(SUM(PLN_NONTAGLIS.RUPIAH),0) AS PLN_NONTAGLIS_RUPIAH,
ISNULL(SUM(PLN_NONTAGLIS.KOMISI),0) AS PLN_NONTAGLIS_KOMISI,

-- PDAM Medan --
ISNULL(SUM(PDAM_MEDAN.JUMLAH),0) AS PDAM_MEDAN_JUMLAH,
ISNULL(SUM(PDAM_MEDAN.RUPIAH),0) AS PDAM_MEDAN_RUPIAH,
ISNULL(SUM(PDAM_MEDAN.KOMISI),0) AS PDAM_MEDAN_KOMISI
-- END OF PDAM Medan
-- END OF GENERATOR SIX --

FROM
cteData tt
LEFT JOIN (
select * from cteData where biller_id = '40001'  --PLN POSTPAID
) AS PLN_POSTPAID ON PLN_POSTPAID.transaction_id = tt.transaction_id
LEFT JOIN (
select * from cteData where biller_id = '40002' --PLN PREPAID
) AS PLN_PREPAID ON PLN_PREPAID.transaction_id = tt.transaction_id
LEFT JOIN (
select * from cteData where biller_id = '40003' --PLN NONTAGLIS
) AS PLN_NONTAGLIS ON PLN_NONTAGLIS.transaction_id = tt.transaction_id
-- END OF PLN --

--PDAM Medan
LEFT JOIN (
select * from cteData where biller_id = '701281'
) AS PDAM_MEDAN ON PDAM_MEDAN.transaction_id = tt.transaction_id
--END OF PDAM Medan
-- END OF GENERATOR SEVEN --

GROUP BY
tt.transaction_date,
tt.branch_id,
tt.branch_name,
tt.collecting_agent_id,
tt.collecting_agent_name
) AS T
) AS T2
order by T2.transaction_date
END"
        ;
            return inputData;
        }
    }
}
