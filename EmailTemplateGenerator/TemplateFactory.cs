using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailTemplateGenerator
{
    class TemplateFactory
    {
        private Dictionary<string, Template> templates;
        public TemplateFactory()
        {
            templates = new Dictionary<string, Template>();
            templates.Add("Low Disk Space", new Template("Hi {0},\nWe are currently receiving alerts for low disk space on drive {1} for {2}.The current amount of free space is {3} GB out of {4}.Please review this disk with a view to make more space, or alternatively consider adding more capacity to this drive.\nIn the meantime, I have lowered our disk space alerting levels to {5} GB from {6} GB.\nCheers\nOscar MacdonaldDatabase Administrator\nSQL Services Ltd\nPH: 0800 696 111", new UserControlLowDiskSpace()));
            templates.Add("Backups (managed by client)", new Template("Hi {0},\n\nWe've been alerted to the '{1}' database on the {2} instance as not having received a backup since {3}. \nAlthough database backups are not our responsibility on this instance, our monitoring template has raised an alert because no backup has been taken in the previous 24 hours.\nIt’s recommended that this is investigated and manual backup taken, in order to ensure the database remains recoverable.\nCheers\nOscar Macdonald\nDatabase Administrator\nSQL Services Ltd\nPH: 0800 696 111"));
            templates.Add("Failed Logins", new Template("Hi {0},\nWe have been alerted to multiple failed logins for the ‘{1}’ account in the {2} instance.\nThe reason SQL Server has provided is as follows:\n{3}\nPlease advise us if these failed logins are not of concern or if further assistance is required.\nCheers\nOscar Macdonald\nDatabase Administrator\nSQL Services Ltd\nPH: 0800 696 111"));
            templates.Add("Database Created (Full)", new Template("Hi {0},\n\nWe have been alerted to a new database created called ‘{1}’ in the {2} instance. I have added this database to our monitoring, which means that it will receive daily full backups, hourly transaction log backups, and it has been included within our optimisation and consistency check job routines.Please advise if this is not expected.\nCheers\nOscar Macdonald\nDatabase Administrator\nSQL Services Ltd\nPH: 0800 696 111"));
            templates.Add("Multiple Databases Created (Full)", new Template("Hi {0},\n\nWe have been alerted to new databases created (see list below) in the {2} instance. I have added these database to our monitoring, which means that they will receive daily full backups, hourly transaction log backups, and have been included within our optimisation and consistency check job routines.Please advise if this is not expected.\n{3}\nCheers\nOscar Macdonald\nDatabase Administrator\nSQL Services Ltd\nPH: 0800 696 111"));
            templates.Add("Database Created (Simple)", new Template("Hi {0},\n\nWe have been alerted to a new database created called ‘{1}’ in the {2} instance. I have added this database to our monitoring, which means that it will receive daily full backups and it has been included within our optimisation and consistency check job routines.Please advise if this is not expected.\nCheers\nOscar Macdonald\nDatabase Administrator\nSQL Services Ltd\nPH: 0800 696 111"));
            templates.Add("Multiple Databases Created (Simple)", new Template("Hi {0},\n\nWe have been alerted to new databases created (see list below) in the {2} instance. I have added these database to our monitoring, which means that they will receive daily full backups and have been included within our optimisation and consistency check job routines.Please advise if this is not expected.\n{3}\nCheers\nOscar Macdonald\nDatabase Administrator\nSQL Services Ltd\nPH: 0800 696 111"));
            templates.Add("Multiple databases created (Both)", new Template("Hi {0},\nWe have been alerted to new databases created in the {1} instance(see list below).\nFor the database(s) in SIMPLE recovery: I have added these databases to our monitoring, which means that they will receive daily full backups and have been included within our optimisation and consistency check job routines.\nFor the database(s) in FULL recovery: I have added these databases to our monitoring, which means that they will receive daily full backups, hourly transaction log backups, and have been included within our optimisation and consistency check job routines.\nPlease advise if these actions are not expected.\n{2}\nCheers\nOscar Macdonald\nDatabase Administrator\nSQL Services Ltd\nPH: 0800 696 111"));
            templates.Add("Database deleted", new Template("Hi {0},\nWe have been alerted to a deleted database called ‘{1}’ in the {2} instance.I have removed this database from our monitoring. Please advise if this is not expected.\nCheers\nOscar Macdonald\nDatabase Administrator\nSQL Services Ltd\nPH: 0800 696 111"));
            templates.Add("New Disk", new Template("Hi {0},\nWe have been alerted to a new disk drive {1}: for the {2} server.I have added this disk to our monitoring, which means that we will receive disk space warnings at 10 % free space and alerts at 5 % free space. Please advise if this is not expected.\nCheers\nOscar Macdonald\nDatabase Administrator\nSQL Services Ltd\nPH: 0800 696 111"));
            templates.Add("Excessive Blocking", new Template("Hi {0},\nWe have been alerted to excessive blocking on the {1} instance.The main blocker(SPID {2}) is the following query:\n{3}\nIn order to resolve this issue, it is recommended that this process is reviewed with the view of ending the process.\nCheers\nOscar Macdonald\nDatabase Administrator\nSQL Services Ltd\nPH: 0800 696 111"));
            templates.Add("Planned SQL Server Restart", new Template("Hi {0},\nWe have been alerted to a SQL Server restart for {1}.The instance shut down occurred around {2}.\nIt appears to have successfully restarted along with SQL Server.\nPlease advise if any assistance is required.\nCheers\nOscar Macdonald\nDatabase Administrator\nSQL Services Ltd\nPH: 0800 696 111"));
        }

        public Template BuildTemplate(string templateName)
        {
            return templates.TryGetValue(templateName,  );
        }
    }
}
