SELECT  
    LTRIM(RTRIM(UPPER(CustCode))) AS [Client],
    LTRIM(RTRIM(UPPER(ServerName))) AS [Instance],
    CASE 
        WHEN (NextReportDue<DATEADD(YEAR, 1, GETDATE())) THEN ReportingPeriod
        ELSE 'None'
    END AS [ReportingPeriod],
    NextReportDue,
    PrimaryDBAName
FROM 
dbo.vw_ServerAllocations