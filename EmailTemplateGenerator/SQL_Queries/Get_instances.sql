SELECT DISTINCT 
    LTRIM(RTRIM(UPPER(i.Config_Name))) AS [Instance], 
FROM cwwebapp_sqlservices.dbo.Config i WITH (NOLOCK)
    LEFT JOIN cwwebapp_sqlservices.dbo.Company c WITH (NOLOCK) ON c.Company_RecID = i.Company_RecID
    INNER JOIN cwwebapp_sqlservices.dbo.v_agr_search_screen a WITH (NOLOCK) ON c.Company_RecID = a.company_recid
    LEFT JOIN cwwebapp_sqlservices.dbo.Billing_Unit b WITH (NOLOCK) ON b.Billing_Unit_RecID = i.Billing_Unit_RecID
WHERE 
    ISNULL(i.Date_Expiration, GETDATE()) >= DATEADD(MONTH, -6, GETDATE()) --CHANGE: 13/05/2013