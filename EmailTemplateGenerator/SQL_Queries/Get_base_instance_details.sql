SELECT DISTINCT 
	LTRIM(RTRIM(UPPER(i.Config_Name))) AS [Instance], 
	LTRIM(RTRIM(UPPER(c.Company_ID))) AS [Client], 
	i.Billing_Unit_RecID AS [Team_ID], 
	ISNULL(REPLACE(b.Billing_Unit_ID,'Team ',''),'') AS [Team_Name],
	ISNULL(LTRIM(RTRIM(i.Serial_Number)),'') AS [SLA], 
	LTRIM(i.Model_Number) AS [TAM], 
	LTRIM(i.Tag_Number) AS [BDM], 
	c.Company_Name, 
	i.Config_RecID AS [Instance_ID],
	CONVERT(VARCHAR(10),i.Date_Expiration, 121) AS [Expiry]
FROM cwwebapp_sqlservices.dbo.Config i WITH (NOLOCK)
	LEFT JOIN cwwebapp_sqlservices.dbo.Company c WITH (NOLOCK) ON c.Company_RecID = i.Company_RecID
	INNER JOIN cwwebapp_sqlservices.dbo.v_agr_search_screen a WITH (NOLOCK) ON c.Company_RecID = a.company_recid
	LEFT JOIN cwwebapp_sqlservices.dbo.Billing_Unit b WITH (NOLOCK) ON b.Billing_Unit_RecID = i.Billing_Unit_RecID
WHERE 
	i.Billing_Unit_RecID IN (".implode(',', $teams).") 
--	AND a.agr_noEnd_flag=1 -- Change: 03/07/2017
--	AND a.agr_cancel_flag=0 -- Change: 03/07/2017
	AND ISNULL(i.Date_Expiration, GETDATE()) >= DATEADD(MONTH, -6, GETDATE()) --CHANGE: 13/05/2013
ORDER BY [Client]