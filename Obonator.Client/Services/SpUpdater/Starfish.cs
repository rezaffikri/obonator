using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Obonator.Client.Services.SpUpdater
{
    public static class Starfish
    {
        public static string StarfishSpExample()
        {
            string inputData = @"USE [starfish_dev]
GO
/****** Object:  StoredProcedure [dbo].[uspReportCommision_Ca]    Script Date: 2/21/2020 1:34:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*
This software, all associated documentation, and all copies are CONFIDENTIAL INFORMATION of PT. Arranet Indonesia Sejahtera.

Created By    	: rully ramadhan
Create Date 	: 2018-01-08
Description   	: Laporan Komisi Downline LEVEL CA
Revised By    	:

Date			User				Note
-------------------------------------------------------------------------------------------------------------------------
2020-02-11      Reza                Tambah PDAM Medan
End Revised

Sample Data		: uspReportCommision_Ca 9,'2018-01-01 00:00:00.000','2018-01-08 00:00:00.000',
*/
ALTER PROCEDURE [dbo].[uspReportCommision_Ca]
(
@institution_id INT,
@date_from DATETIME,
@date_to DATETIME
)
AS
BEGIN
-- SET NOCOUNT ON added to prevent extra result sets from
-- interfering with SELECT statements.
SET NOCOUNT ON;

--DECLARE	@institution_id INT
--DECLARE	@date_from DATETIME
--DECLARE	@date_to DATETIME

--SET @institution_id = 56
--SET @date_from = '2018-01-04 00:00:00.000'
--SET @date_to = '2018-01-08 23:00:00.000'
;WITH
cte_biller_id
as
(
Select *,ROW_NUMBER()Over(partition by biller_id,institution_id,institution_type_id	Order by commission_id asc) Rn
From ref_commission with (nolock)
),
CTE_DATA AS (
SELECT distinct rc.biller_id,
rc.institution_id,
max(rc.amount)as amount,
sum(isnull(itt.amount_sell,0)) as rupiah,
SUM(isnull(itt.jumlah,0)) AS jumlah,
rc.rn as rn
FROM
cte_biller_id rc
LEFT JOIN
(
SELECT cb.biller_id, sub_collecting_agent_id,amount_sell,
case cb.biller_id
WHEN 40001 THEN sum(CONVERT(INT, CASE WHEN IsNumeric(CONVERT(VARCHAR(12), SUBSTRING(private_data_48,20,1))) = 1 then CONVERT(VARCHAR(12), SUBSTRING(private_data_48,20,1)) else 0 End))
ELSE FORMAT(COUNT(description),'N0')
END[JUMLAH]
FROM dbo.trx_transaction with (nolock)
INNER JOIN com_biller cb ON cb.biller_id = trx_transaction.biller_id
WHERE resp_code = '0000'
--AND CB.BILLER_ID <> 140001
AND create_date >= @date_from
AND create_date <= @date_to
GROUP BY cb.biller_id,transaction_id, sub_collecting_agent_id,amount_sell
) AS itt
ON itt.biller_id = rc.biller_id AND itt.sub_collecting_agent_id = rc.institution_id
WHERE rc.institution_type_id = 4 and rc.rn = 1
GROUP BY
rc.rn,rc.institution_id, rc.biller_id
)
, CTE_DATA_UPLINE AS (
SELECT distinct rcu.biller_id,sca.sub_collecting_agent_id,(rcu.amount - cte.amount) as profit,cte.jumlah
FROM ref_commission rcu with (nolock)
INNER JOIN com_biller cb with (nolock) on cb.biller_id = rcu.biller_id
INNER JOIN ref_collecting_agent ca with (nolock) on ca.collecting_agent_id = rcu.institution_id and rcu.institution_type_id = 3
INNER JOIN ref_sub_collecting_agent sca with (nolock) on sca.collecting_agent_id = @institution_id
INNER JOIN CTE_DATA cte on cte.institution_id = sca.sub_collecting_agent_id AND cb.biller_id = CTE.biller_id
WHERE
-- CB.BILLER_ID <> 140001 and
cte.rn = 1
)

SELECT

DOWNLINE,
PLN_POSTPAID_JUMLAH,
PLN_POSTPAID_RUPIAH,
PLN_POSTPAID_KOMISI,
PLN_PREPAID_JUMLAH,
PLN_PREPAID_RUPIAH,
PLN_PREPAID_KOMISI,
PLN_NONTAGLIS_JUMLAH,
PLN_NONTAGLIS_RUPIAH,
PLN_NONTAGLIS_KOMISI,
(PLN_POSTPAID_JUMLAH + PLN_PREPAID_JUMLAH + PLN_NONTAGLIS_JUMLAH) AS PLN_JUMLAH,
(PLN_POSTPAID_RUPIAH + PLN_PREPAID_RUPIAH + PLN_NONTAGLIS_RUPIAH) AS PLN_RUPIAH,
(PLN_POSTPAID_KOMISI + PLN_PREPAID_KOMISI + PLN_NONTAGLIS_KOMISI) AS PLN_KOMISI,

-- PDAM Medan --
PDAM_MEDAN_JUMLAH,
PDAM_MEDAN_RUPIAH,
PDAM_MEDAN_KOMISI,
-- END OF PDAM Medan --
-- END OF GENERATOR ONE --

-- ALL SUMMARY NON PLN --

(
-- PDAM Medan --
PDAM_MEDAN_JUMLAH
-- END OF PDAM Medan --
-- END OF GENERATOR TWO --
) AS NON_PLN_JUMLAH,
(
-- PDAM Medan --
PDAM_MEDAN_RUPIAH
-- END OF PDAM Medan --
-- END OF GENERATOR THREE --
) AS NON_PLN_RUPIAH,
(
-- PDAM Medan --
PDAM_MEDAN_KOMISI
-- END OF PDAM Medan --
-- END OF GENERATOR FOUR --
) AS NON_PLN_KOMISI,

-- END OF SUMMARY NON PLN --

--(PLN_POSTPAID_JUMLAH+PLN_PREPAID_JUMLAH+PLN_NONTAGLIS_JUMLAH+TELCO_PREPAID_SIMPATI_JUMLAH+TELCO_PREPAID_AS_JUMLAH+TELCO_PREPAID_MENTARI_JUMLAH+TELCO_PREPAID_IM3_JUMLAH+
-- TELCO_PREPAID_TRI_JUMLAH + TELCO_PREPAID_XLAXIS_JUMLAH + TELCO_PREPAID_SMARTFREN_JUMLAH + TELCO_DATA_TELKOMSEL_JUMLAH + TELCO_DATA_XLAXIS_JUMLAH + TELCO_POSTPAID_TELKOMSEL_JUMLAH + TELCO_POSTPAID_INDOSAT_JUMLAH + TELCO_POSTPAID_TRI_JUMLAH+
-- TELCO_POSTPAID_XLAXIS_JUMLAH + TELCO_POSTPAID_SMARTFREN_JUMLAH + TELCO_POSTPAID_SMARTFREN_JUMLAH + TELCO_POSTPAID_TELKOM_PSTN_JUMLAH + TELCO_POSTPAID_TELKOM_SPEEDY_JUMLAH + BPJS_KESEHATAN_JUMLAH +
-- PDAM_AETRA_JAKARTA_JUMLAH + PDAM_KABUPATEN_BOGOR_JUMLAH + PDAM_KOTA_BANDAR_LAMPUNG_JUMLAH + PDAM_KOTA_BANDUNG_JUMLAH + PDAM_KOTA_BOGOR_JUMLAH + PDAM_KOTA_DEPOK_JUMLAH + PDAM_KOTA_MATARAM_JUMLAH +
-- PDAM_KOTA_PALEMBANG_JUMLAH + PDAM_KOTA_SEMARANG_JUMLAH + PDAM_KOTA_SURABAYA_JUMLAH + PDAM_PALYJA_JAKARTA_JUMLAH + PDAM_CIREBON_JUMLAH + PDAM_DENPASAR_JUMLAH + PDAM_BADUNG_JUMLAH +
-- PDAM_BATAM_JUMLAH + PDAM_INTAN_BANJAR_JUMLAH + PDAM_BANDARMASIH_JUMLAH + CAR_OPEN_AMOUNT_JUMLAH + CAR_CLOSE_AMOUNT_JUMLAH + DENS_TV_JUMLAH + PAM_BSD_JUMLAH + BIG_TV_JUMLAH + GOJEK_CUSTOMER_JUMLAH +
-- BUKOPIN_FINANCE_JUMLAH + BAF_JUMLAH + KAI_JUMLAH + AIRLINE_JUMLAH + PBB_DKI_SPPT_JUMLAH) AS JUMLAH,

--JUMLAH_BILLER_TRX --DIKOMEN BUAT CEK SELISIH,


(PLN_POSTPAID_RUPIAH+PLN_PREPAID_RUPIAH+PLN_NONTAGLIS_RUPIAH+ PDAM_MEDAN_RUPIAH
-- END OF GENERATOR FIVE --
)-
(PLN_POSTPAID_KOMISI+PLN_PREPAID_KOMISI+PLN_NONTAGLIS_KOMISI+ PDAM_MEDAN_KOMISI
-- END OF GENERATOR SIX --
) AS TOTAL_SETORAN,
TOTAL_PROFIT,

(PLN_POSTPAID_RUPIAH+PLN_PREPAID_RUPIAH+PLN_NONTAGLIS_RUPIAH+TOPUP_GRAB_DRIVER_RUPIAH + MNC_VISION_RUPIAH + MNC_PLAY_RUPIAH + MNC_SHOP_RUPIAH + MNC_FINANCE_RUPIAH + WOM_RUPIAH + TOPUP_LINKAJA_RUPIAH + UNRAM_RUPIAH + LSP_NONTAGLIS_RUPIAH
+ PDAM_MEDAN_RUPIAH
-- END OF GENERATOR SEVEN --
)-
(PLN_POSTPAID_KOMISI+PLN_PREPAID_KOMISI+PLN_NONTAGLIS_KOMISI+ PDAM_MEDAN_KOMISI
-- END OF GENERATOR EIGHT --
)-TOTAL_PROFIT AS TOTAL_SETORAN_KE_UPLINE

FROM
(

SELECT
--ins.sub_collecting_agent_id,
ins.sub_collecting_agent_name as DOWNLINE,
--SUM(CDU.JUMLAH) AS JUMLAH_BILLER_TRX, --DIKOMEN BUAT CEK SELISIH BILLER
-- PLN --
ISNULL(PLN_POSTPAID.jumlah,0) AS PLN_POSTPAID_JUMLAH,
ISNULL(PLN_POSTPAID.rupiah,0) AS PLN_POSTPAID_RUPIAH,
(ISNULL(PLN_POSTPAID.jumlah,0) * ISNULL(PLN_POSTPAID.amount,0)) AS PLN_POSTPAID_KOMISI,

ISNULL(PLN_PREPAID.jumlah,0) AS PLN_PREPAID_JUMLAH,
ISNULL(PLN_PREPAID.rupiah,0) AS PLN_PREPAID_RUPIAH,
(ISNULL(PLN_PREPAID.jumlah,0) * ISNULL(PLN_PREPAID.amount,0)) AS PLN_PREPAID_KOMISI,

ISNULL(PLN_NONTAGLIS.jumlah,0) AS PLN_NONTAGLIS_JUMLAH,
ISNULL(PLN_NONTAGLIS.rupiah,0) AS PLN_NONTAGLIS_RUPIAH,
(ISNULL(PLN_NONTAGLIS.jumlah,0) * ISNULL(PLN_NONTAGLIS.amount,0)) AS PLN_NONTAGLIS_KOMISI,
-- END OF PLN --

-- PDAM Medan --
ISNULL(PDAM_MEDAN.jumlah,0) AS PDAM_MEDAN_JUMLAH,
ISNULL(PDAM_MEDAN.rupiah,0) AS PDAM_MEDAN_RUPIAH,
(ISNULL(PDAM_MEDAN.jumlah,0) * ISNULL(PDAM_MEDAN.amount,0)) AS PDAM_MEDAN_KOMISI,
-- END OF PDAM Medan --
-- END OF GENERATOR NINE --

-- total profit --
isnull(sum(cdu.profit * cdu.jumlah),0) as TOTAL_PROFIT
-- end total profit --
FROM
dbo.ref_sub_collecting_agent ins
LEFT JOIN (
SELECT * FROM CTE_DATA WHERE biller_id = '40001' --PLN POSTPAID
) AS PLN_POSTPAID ON PLN_POSTPAID.institution_id = ins.sub_collecting_agent_id
LEFT JOIN (
SELECT * FROM CTE_DATA WHERE biller_id = '40002' --PLN PREPAID
) AS PLN_PREPAID ON PLN_PREPAID.institution_id = ins.sub_collecting_agent_id
LEFT JOIN (
SELECT * FROM CTE_DATA WHERE biller_id = '40003' --PLN NONTAGLIS
) AS PLN_NONTAGLIS ON PLN_NONTAGLIS.institution_id = ins.sub_collecting_agent_id

-- PDAM Medan --
LEFT JOIN (
select * from CTE_DATA where biller_id = '50039'
) AS PDAM_MEDAN ON PDAM_MEDAN.institution_id = ins.sub_collecting_agent_id
-- END OF PDAM Medan --
--jika di ca pakai format dibawah ini
-- END OF GENERATOR TEN CA --
jika di sub ca pakai format dibawah ini
-- END OF GENERATOR TEN SUB CA --
LEFT JOIN CTE_DATA_UPLINE cdu on cdu.sub_collecting_agent_id = ins.sub_collecting_agent_id


WHERE
ins.collecting_agent_id = @institution_id
GROUP BY
ins.sub_collecting_agent_id,
ins.sub_collecting_agent_code,
ins.sub_collecting_agent_name,
PLN_POSTPAID.jumlah,
PLN_POSTPAID.rupiah,
PLN_POSTPAID.amount,

PLN_PREPAID.jumlah,
PLN_PREPAID.rupiah,
PLN_PREPAID.amount,

PLN_NONTAGLIS.jumlah,
PLN_NONTAGLIS.rupiah,
PLN_NONTAGLIS.amount
,
-- PDAM Medan --
PDAM_MEDAN.jumlah,
PDAM_MEDAN.rupiah,
PDAM_MEDAN.amount
-- END OF PDAM Medan --
-- END OF GENERATOR ELEVEN --
)
AS REPORT_SETORAN

END"
;
            return inputData;
        }
    }
}
