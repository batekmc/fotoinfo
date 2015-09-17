using SmartISLib;
using SmartISLib.ORM;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoInfo.Data
{
    class QFTimesRevisionDialog: DbObject
    {

        private static DbSchema schema = null;

        public int TimesRevisionID
        {
            get { return DbConverter.ToInt(this["TimesRevisionID"]); }
            set { this["TimesRevisionID"] = DbConverter.FromInt(value); }
        }

        public int Revision
        {
            get { return DbConverter.ToInt(this["Revision"]); }
            set { this["Revision"] = DbConverter.FromInt(value); }
        }

        public DbNullable<int> Component
        {
            get { return DbConverter.ToIntNull(this["Component"]); }
            set { this["Component"] = DbConverter.FromIntNull(value); }
        }

        public decimal IFU_value
        {
            get { return DbConverter.ToDecimal(this["IFU_value"]); }
            set { this["IFU_value"] = DbConverter.FromDecimal(value); }
        }

        public DbNullable<decimal> TimeKoef
        {
            get { return DbConverter.ToDecimalNull(this["TimeKoef"]); }
            set { this["TimeKoef"] = DbConverter.FromDecimalNull(value); }
        }

        public DbNullable<int> Correction
        {
            get { return DbConverter.ToIntNull(this["Correction"]); }
            set { this["Correction"] = DbConverter.FromIntNull(value); }
        }

        public DbNullable<string> CorrectionNote
        {
            get { return DbConverter.ToStringNull(this["CorrectionNote"]); }
            set { this["CorrectionNote"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<int> PickType
        {
            get { return DbConverter.ToIntNull(this["PickType"]); }
            set { this["PickType"] = DbConverter.FromIntNull(value); }
        }

        public bool CheckPackage
        {
            get { return DbConverter.ToBool(this["CheckPackage"]); }
            set { this["CheckPackage"] = DbConverter.FromBool(value); }
        }

        public DateTime Created
        {
            get { return DbConverter.ToDateTime(this["Created"]); }
            set { this["Created"] = DbConverter.FromDateTime(value); }
        }

        public string CreatedBy
        {
            get { return DbConverter.ToString(this["CreatedBy"]); }
            set { this["CreatedBy"] = DbConverter.FromString(value); }
        }

        public bool Actual
        {
            get { return DbConverter.ToBool(this["Actual"]); }
            set { this["Actual"] = DbConverter.FromBool(value); }
        }

        public DbNullable<int> MainComponent
        {
            get { return DbConverter.ToIntNull(this["MainComponent"]); }
            set { this["MainComponent"] = DbConverter.FromIntNull(value); }
        }

        public DbNullable<string> Note
        {
            get { return DbConverter.ToStringNull(this["Note"]); }
            set { this["Note"] = DbConverter.FromStringNull(value); }
        }

        public int TypeRevision
        {
            get { return DbConverter.ToInt(this["TypeRevision"]); }
            set { this["TypeRevision"] = DbConverter.FromInt(value); }
        }

        public bool IFU
        {
            get { return DbConverter.ToBool(this["IFU"]); }
            set { this["IFU"] = DbConverter.FromBool(value); }
        }

        public bool RevisionDone
        {
            get { return DbConverter.ToBool(this["RevisionDone"]); }
            set { this["RevisionDone"] = DbConverter.FromBool(value); }
        }


        public DbNullable<string> FileLink
        {
            get { return DbConverter.ToStringNull(this["FileLink"]); }
            set { this["FileLink"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<int> MainCompRevision
        {
            get { return DbConverter.ToIntNull(this["MainCompRevision"]); }
            set { this["MainCompRevision"] = DbConverter.FromIntNull(value); }
        }

        public DbNullable<int> IFU_type
        {
            get { return DbConverter.ToIntNull(this["IFU_type"]); }
            set { this["IFU_type"] = DbConverter.FromIntNull(value); }
        }
        //NEW
        public DbNullable<string> CompCode
        {
            get { return DbConverter.ToStringNull(this["CompCode"]); }
            set { this["CompCode"] = DbConverter.FromStringNull(value); }
        }
        public DbNullable<string> CompCategory
        {
            get { return DbConverter.ToStringNull(this["CompCategory"]); }
            set { this["CompCategory"] = DbConverter.FromStringNull(value); }
        }
        public DbNullable<string> CompStatus
        {
            get { return DbConverter.ToStringNull(this["CompStatus"]); }
            set { this["CompStatus"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> CompComent
        {
            get { return DbConverter.ToStringNull(this["CompComent"]); }
            set { this["CompComent"] = DbConverter.FromStringNull(value); }
        }
        public DateTime CompPhotoDate
        {
            get { return DbConverter.ToDateTime(this["CompPhotoDate"]); }
            set { this["CompPhotoDate"] = DbConverter.FromDateTime(value); }
        }
        public bool CompTimesRevision
        {
            get { return DbConverter.ToBool(this["CompTimesRevision"]); }
            set { this["CompTimesRevision"] = DbConverter.FromBool(value); }
        }
        public bool TimeRevisionMainComp
        {
            get { return DbConverter.ToBool(this["TimeRevisionMainComp"]); }
            set { this["TimeRevisionMainComp"] = DbConverter.FromBool(value); }
        }
        public bool TimeRevisionComp
        {
            get { return DbConverter.ToBool(this["TimeRevisionComp"]); }
            set { this["TimeRevisionComp"] = DbConverter.FromBool(value); }
        }

        protected override DbSchema GetSchema()
        {
            if (schema == null)
            {
                schema = new DbSchema("QFTimesRevisionDialog");
                schema.Add("TimesRevisionID", typeof(int), "TimesRevisionID", false, true, true);
                schema.Add("Revision", typeof(int), "Revision", false);
                schema.Add("Component", typeof(int), "Component", true);
                schema.Add("IFU_value", typeof(decimal), "IFU_value", false);
                schema.Add("TimeKoef", typeof(decimal), "TimeKoef", false);
                schema.Add("Correction", typeof(int), "Correction", true);
                schema.Add("CorrectionNote", typeof(string), "CorrectionNote", true);
                schema.Add("PickType", typeof(int), "PickType", true);
                schema.Add("CheckPackage", typeof(bool), "CheckPackage", false);
                schema.Add("Created", typeof(DateTime), "Created", false);
                schema.Add("CreatedBy", typeof(string), "CreatedBy", false);
                schema.Add("Actual", typeof(bool), "Actual", false);
                schema.Add("MainComponent", typeof(int), "MainComponent", true);
                schema.Add("Note", typeof(string), "Note", true);
                schema.Add("TypeRevision", typeof(int), "TypeRevision", false);
                schema.Add("IFU", typeof(bool), "IFU", false);
                schema.Add("RevisionDone", typeof(bool), "RevisionDone", false);
                schema.Add("FileLink", typeof(string), "FileLink", true);
                schema.Add("MainCompRevision", typeof(int), "MainCompRevision", true);
                schema.Add("IFU_type", typeof(int), "IFU_type", true);
                schema.Add("CompCode", typeof(string), "CompCode", true);
                schema.Add("CompCategory", typeof(string), "CompCategory", true);
                schema.Add("CompStatus", typeof(string), "CompStatus", true);
                schema.Add("CompComent", typeof(string), "CompComent", true);
                schema.Add("CompPhotoDate", typeof(DateTime), "CompPhotoDate", true);
                schema.Add("CompTimesRevision", typeof(bool), "CompTimesRevision", true);
                schema.Add("TimeRevisionMainComp", typeof(bool), "TimeRevisionMainComp", true);
                schema.Add("TimeRevisionComp", typeof(bool), "TimeRevisionComp", true);
            }

            return schema;
        }

        public override void LoadDefaultValues()
        {
            SqlCommand command = Session.CreateCommand();

            this["TimesRevisionID"] = DbConverter.DefaultInt();

            command.CommandText = "SELECT ((0))";
            this["Revision"] = command.ExecuteScalar();

            this["Component"] = DBNull.Value;

            command.CommandText = "SELECT ((0))";
            this["IFU_value"] = command.ExecuteScalar();

            this["TimeKoef"] = DBNull.Value;

            this["Correction"] = DBNull.Value;

            this["CorrectionNote"] = DBNull.Value;

            this["PickType"] = DBNull.Value;

            command.CommandText = "SELECT ((0))";
            this["CheckPackage"] = command.ExecuteScalar();

            command.CommandText = "SELECT (getdate())";
            this["Created"] = command.ExecuteScalar();

            command.CommandText = "SELECT ([dbo].[FceUserMSSQL]())";
            this["CreatedBy"] = command.ExecuteScalar();

            command.CommandText = "SELECT ((0))";
            this["Actual"] = command.ExecuteScalar();

            this["MainComponent"] = DBNull.Value;

            this["Note"] = DBNull.Value;

            command.CommandText = "SELECT ((2))";
            this["TypeRevision"] = command.ExecuteScalar();

            command.CommandText = "SELECT ((0))";
            this["IFU"] = command.ExecuteScalar();

            command.CommandText = "SELECT ((0))";
            this["RevisionDone"] = command.ExecuteScalar();

            this["FileLink"] = DBNull.Value;

            this["MainCompRevision"] = DBNull.Value;

            this["IFU_type"] = DBNull.Value;

            this["CompCode"] = DBNull.Value;

            this["CompCategory"] = DBNull.Value;
            
            this["CompStatus"] = DBNull.Value;
            
            this["CompComent"] = DBNull.Value;
            
            this["CompPhotoDate"] = DBNull.Value;
            
            this["CompTimesRevision"] = DBNull.Value;
            
            this["TimeRevisionMainComp"] = DBNull.Value;
            
            this["TimeRevisionComp"] = DBNull.Value;
        }

        public static QFTimesRevisionDialog Load(int timesRevisionID)
        {
            SqlCommand str = Session.CreateCommand();
            Console.WriteLine(str.CommandText + "_____________________");
            QFTimesRevisionDialog result = new QFTimesRevisionDialog();
            result.LoadRecord(timesRevisionID);
            return result;
        }

        public static QFTimesRevisionDialog CachedLoad(int timesRevisionID)
        {
            DbCache.TableKey key = new DbCache.TableKey("QFTimesRevisionDialog");
            DbCache.CacheRecord record;
            key.Set(timesRevisionID);
            if (DbCache.Contains(key))
            {
                record = DbCache.GetRecord(key);
                if (!record.IsValid())
                {
                    record.Value = Load(timesRevisionID);
                    record.LastUpdate = DateTime.Now;
                    record.Valid = true;
                }
            }
            else
            {
                record = new DbCache.CacheRecord();
                record.Value = Load(timesRevisionID);
                record.LastUpdate = DateTime.Now;
                record.Valid = true;
                DbCache.SetRecord(key, record);
            }
            return (QFTimesRevisionDialog)record.Value;
        }

        public static QFTimesRevisionDialog Create()
        {
            QFTimesRevisionDialog result = new QFTimesRevisionDialog();
            result.LoadDefaultValues();
            return result;
        }

        public static DbTable<QFTimesRevisionDialog> LoadAll()
        {
            DbTable<QFTimesRevisionDialog> table = new DbTable<QFTimesRevisionDialog>();
            QFTimesRevisionDialog prototype = new QFTimesRevisionDialog();
            prototype.LoadTable(table);
            return table;
        }

        public static DbTable<QFTimesRevisionDialog> LoadByComponent(DbNullable<int> component)
        {
            DbTable<QFTimesRevisionDialog> table = new DbTable<QFTimesRevisionDialog>();
            QFTimesRevisionDialog prototype = new QFTimesRevisionDialog();
            prototype.LoadTable(table, "[Component]={0}", DbConverter.FromIntNull(component));
            return table;
        }

        public static DbTable<QFTimesRevisionDialog> LoadByCorrection(DbNullable<int> correction)
        {
            DbTable<QFTimesRevisionDialog> table = new DbTable<QFTimesRevisionDialog>();
            QFTimesRevisionDialog prototype = new QFTimesRevisionDialog();
            prototype.LoadTable(table, "[Correction]={0}", DbConverter.FromIntNull(correction));
            return table;
        }

        public static DbTable<QFTimesRevisionDialog> LoadByPickType(DbNullable<int> pickType)
        {
            DbTable<QFTimesRevisionDialog> table = new DbTable<QFTimesRevisionDialog>();
            QFTimesRevisionDialog prototype = new QFTimesRevisionDialog();
            prototype.LoadTable(table, "[PickType]={0}", DbConverter.FromIntNull(pickType));
            return table;
        }

        public static DbTable<QFTimesRevisionDialog> LoadByTypeRevision(int typeRevision)
        {
            DbTable<QFTimesRevisionDialog> table = new DbTable<QFTimesRevisionDialog>();
            QFTimesRevisionDialog prototype = new QFTimesRevisionDialog();
            prototype.LoadTable(table, "[TypeRevision]={0}", DbConverter.FromInt(typeRevision));
            return table;
        }

        public static DbTable<QFTimesRevisionDialog> LoadByIFU_type(DbNullable<int> iFU_type)
        {
            DbTable<QFTimesRevisionDialog> table = new DbTable<QFTimesRevisionDialog>();
            QFTimesRevisionDialog prototype = new QFTimesRevisionDialog();
            prototype.LoadTable(table, "[IFU_type]={0}", DbConverter.FromIntNull(iFU_type));
            return table;
        }

        public static DbTable<QFTimesRevisionDialog> LoadBy(string whereCondition, params object[] parameterValues)
        {
            DbTable<QFTimesRevisionDialog> table = new DbTable<QFTimesRevisionDialog>();
            QFTimesRevisionDialog prototype = new QFTimesRevisionDialog();
            prototype.LoadTable(table, whereCondition, parameterValues);
            return table;
        }

    }
}
