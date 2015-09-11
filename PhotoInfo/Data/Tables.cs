using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using SmartISLib;
using SmartISLib.ORM;

namespace PhotoInfo.Data
{
    public class TMachine: DbObject
    {
        private static DbSchema schema = null;

        public string Machine
        {
            get { return DbConverter.ToString(this["Machine"]); }
            set { this["Machine"] = DbConverter.FromString(value); }
        }

        protected override DbSchema GetSchema()
        {
            if (schema == null)
            {
                schema = new DbSchema("TMachine");
                schema.Add("Machine", typeof(string), "Machine", false, true, false);
            }

            return schema;
        }

        public override void LoadDefaultValues()
        {
            SqlCommand command = Session.CreateCommand();

            this["Machine"] = DbConverter.DefaultString();
        }

        public static TMachine Load(string machine)
        {
            TMachine result = new TMachine();
            result.LoadRecord(machine);
            return result;
        }

        public static TMachine CachedLoad(string machine)
        {
            DbCache.TableKey key = new DbCache.TableKey("TMachine");
            DbCache.CacheRecord record;
            key.Set(machine);
            if (DbCache.Contains(key))
            {
                record = DbCache.GetRecord(key);
                if (!record.IsValid())
                {
                    record.Value = Load(machine);
                    record.LastUpdate = DateTime.Now;
                    record.Valid = true;
                }
            }
            else
            {
                record = new DbCache.CacheRecord();
                record.Value = Load(machine);
                record.LastUpdate = DateTime.Now;
                record.Valid = true;
                DbCache.SetRecord(key, record);
            }
            return (TMachine)record.Value;
        }

        public static TMachine Create()
        {
            TMachine result = new TMachine();
            result.LoadDefaultValues();
            return result;
        }

        public static DbTable<TMachine> LoadAll()
        {
            DbTable<TMachine> table = new DbTable<TMachine>();
            TMachine prototype = new TMachine();
            prototype.LoadTable(table);
            return table;
        }

        public static DbTable<TMachine> LoadBy(string whereCondition, params object[] parameterValues)
        {
            DbTable<TMachine> table = new DbTable<TMachine>();
            TMachine prototype = new TMachine();
            prototype.LoadTable(table, whereCondition, parameterValues);
            return table;
        }
    }

    public class TTimesRevision: DbObject
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

        public bool RevisionNeeded
        {
            get { return DbConverter.ToBool(this["RevisionNeeded"]); }
            set { this["RevisionNeeded"] = DbConverter.FromBool(value); }
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

        protected override DbSchema GetSchema()
        {
            if (schema == null)
            {
                schema = new DbSchema("TTimesRevision");
                schema.Add("TimesRevisionID", typeof(int), "TimesRevisionID", false, true, true);
                schema.Add("Revision", typeof(int), "Revision", false);
                schema.Add("Component", typeof(int), "Component", true);
                schema.Add("IFU_value", typeof(decimal), "IFU_value", false);
                schema.Add("TimeKoef", typeof(decimal), "TimeKoef", true);
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
                schema.Add("RevisionNeeded", typeof(bool), "RevisionNeeded", false);
                schema.Add("FileLink", typeof(string), "FileLink", true);
                schema.Add("MainCompRevision", typeof(int), "MainCompRevision", true);
                schema.Add("IFU_type", typeof(int), "IFU_type", true);
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

            command.CommandText = "SELECT ([dbo].[FceGetDefaultTimeKoef]())";
            this["TimeKoef"] = command.ExecuteScalar();

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

            command.CommandText = "SELECT ((0))";
            this["RevisionNeeded"] = command.ExecuteScalar();

            this["FileLink"] = DBNull.Value;

            this["MainCompRevision"] = DBNull.Value;

            this["IFU_type"] = DBNull.Value;
        }

        public static TTimesRevision Load(int timesRevisionID)
        {
            TTimesRevision result = new TTimesRevision();
            result.LoadRecord(timesRevisionID);
            return result;
        }

        public static TTimesRevision CachedLoad(int timesRevisionID)
        {
            DbCache.TableKey key = new DbCache.TableKey("TTimesRevision");
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
            return (TTimesRevision)record.Value;
        }

        public static TTimesRevision Create()
        {
            TTimesRevision result = new TTimesRevision();
            result.LoadDefaultValues();
            return result;
        }

        public static DbTable<TTimesRevision> LoadAll()
        {
            DbTable<TTimesRevision> table = new DbTable<TTimesRevision>();
            TTimesRevision prototype = new TTimesRevision();
            prototype.LoadTable(table);
            return table;
        }

        public static DbTable<TTimesRevision> LoadByComponent(DbNullable<int> component)
        {
            DbTable<TTimesRevision> table = new DbTable<TTimesRevision>();
            TTimesRevision prototype = new TTimesRevision();
            prototype.LoadTable(table, "[Component]={0}", DbConverter.FromIntNull(component));
            return table;
        }

        public static DbTable<TTimesRevision> LoadByCorrection(DbNullable<int> correction)
        {
            DbTable<TTimesRevision> table = new DbTable<TTimesRevision>();
            TTimesRevision prototype = new TTimesRevision();
            prototype.LoadTable(table, "[Correction]={0}", DbConverter.FromIntNull(correction));
            return table;
        }

        public static DbTable<TTimesRevision> LoadByPickType(DbNullable<int> pickType)
        {
            DbTable<TTimesRevision> table = new DbTable<TTimesRevision>();
            TTimesRevision prototype = new TTimesRevision();
            prototype.LoadTable(table, "[PickType]={0}", DbConverter.FromIntNull(pickType));
            return table;
        }

        public static DbTable<TTimesRevision> LoadByTypeRevision(int typeRevision)
        {
            DbTable<TTimesRevision> table = new DbTable<TTimesRevision>();
            TTimesRevision prototype = new TTimesRevision();
            prototype.LoadTable(table, "[TypeRevision]={0}", DbConverter.FromInt(typeRevision));
            return table;
        }

        public static DbTable<TTimesRevision> LoadByIFU_type(DbNullable<int> iFU_type)
        {
            DbTable<TTimesRevision> table = new DbTable<TTimesRevision>();
            TTimesRevision prototype = new TTimesRevision();
            prototype.LoadTable(table, "[IFU_type]={0}", DbConverter.FromIntNull(iFU_type));
            return table;
        }

        public static DbTable<TTimesRevision> LoadBy(string whereCondition, params object[] parameterValues)
        {
            DbTable<TTimesRevision> table = new DbTable<TTimesRevision>();
            TTimesRevision prototype = new TTimesRevision();
            prototype.LoadTable(table, whereCondition, parameterValues);
            return table;
        }
    }

    public class TMachineComplaint: DbObject
    {
        private static DbSchema schema = null;

        public string MachineName
        {
            get { return DbConverter.ToString(this["MachineName"]); }
            set { this["MachineName"] = DbConverter.FromString(value); }
        }

        public int ComplaintID
        {
            get { return DbConverter.ToInt(this["ComplaintID"]); }
            set { this["ComplaintID"] = DbConverter.FromInt(value); }
        }

        public DbNullable<bool> Offender
        {
            get { return DbConverter.ToBoolNull(this["Offender"]); }
            set { this["Offender"] = DbConverter.FromBoolNull(value); }
        }

        protected override DbSchema GetSchema()
        {
            if (schema == null)
            {
                schema = new DbSchema("TMachineComplaint");
                schema.Add("MachineName", typeof(string), "MachineName", false, true, false);
                schema.Add("ComplaintID", typeof(int), "ComplaintID", false, true, false);
                schema.Add("Offender", typeof(bool), "Offender", true);
            }

            return schema;
        }

        public override void LoadDefaultValues()
        {
            SqlCommand command = Session.CreateCommand();

            this["MachineName"] = DbConverter.DefaultString();

            this["ComplaintID"] = DbConverter.DefaultInt();

            this["Offender"] = DBNull.Value;
        }

        public static TMachineComplaint Load(string machineName, int complaintID)
        {
            TMachineComplaint result = new TMachineComplaint();
            result.LoadRecord(machineName, complaintID);
            return result;
        }

        public static TMachineComplaint CachedLoad(string machineName, int complaintID)
        {
            DbCache.TableKey key = new DbCache.TableKey("TMachineComplaint");
            DbCache.CacheRecord record;
            key.Set(machineName, complaintID);
            if (DbCache.Contains(key))
            {
                record = DbCache.GetRecord(key);
                if (!record.IsValid())
                {
                    record.Value = Load(machineName, complaintID);
                    record.LastUpdate = DateTime.Now;
                    record.Valid = true;
                }
            }
            else
            {
                record = new DbCache.CacheRecord();
                record.Value = Load(machineName, complaintID);
                record.LastUpdate = DateTime.Now;
                record.Valid = true;
                DbCache.SetRecord(key, record);
            }
            return (TMachineComplaint)record.Value;
        }

        public static TMachineComplaint Create()
        {
            TMachineComplaint result = new TMachineComplaint();
            result.LoadDefaultValues();
            return result;
        }

        public static DbTable<TMachineComplaint> LoadAll()
        {
            DbTable<TMachineComplaint> table = new DbTable<TMachineComplaint>();
            TMachineComplaint prototype = new TMachineComplaint();
            prototype.LoadTable(table);
            return table;
        }

        public static DbTable<TMachineComplaint> LoadByMachineName(string machineName)
        {
            DbTable<TMachineComplaint> table = new DbTable<TMachineComplaint>();
            TMachineComplaint prototype = new TMachineComplaint();
            prototype.LoadTable(table, "[MachineName]={0}", DbConverter.FromString(machineName));
            return table;
        }

        public static DbTable<TMachineComplaint> LoadByComplaintID(int complaintID)
        {
            DbTable<TMachineComplaint> table = new DbTable<TMachineComplaint>();
            TMachineComplaint prototype = new TMachineComplaint();
            prototype.LoadTable(table, "[ComplaintID]={0}", DbConverter.FromInt(complaintID));
            return table;
        }

        public static DbTable<TMachineComplaint> LoadBy(string whereCondition, params object[] parameterValues)
        {
            DbTable<TMachineComplaint> table = new DbTable<TMachineComplaint>();
            TMachineComplaint prototype = new TMachineComplaint();
            prototype.LoadTable(table, whereCondition, parameterValues);
            return table;
        }
    }

    public class TMonth: DbObject
    {
        private static DbSchema schema = null;

        public int IDMonth
        {
            get { return DbConverter.ToInt(this["IDMonth"]); }
            set { this["IDMonth"] = DbConverter.FromInt(value); }
        }

        public DbNullable<string> MonthName
        {
            get { return DbConverter.ToStringNull(this["MonthName"]); }
            set { this["MonthName"] = DbConverter.FromStringNull(value); }
        }

        protected override DbSchema GetSchema()
        {
            if (schema == null)
            {
                schema = new DbSchema("TMonth");
                schema.Add("IDMonth", typeof(int), "IDMonth", false, true, true);
                schema.Add("MonthName", typeof(string), "MonthName", true);
            }

            return schema;
        }

        public override void LoadDefaultValues()
        {
            SqlCommand command = Session.CreateCommand();

            this["IDMonth"] = DbConverter.DefaultInt();

            this["MonthName"] = DBNull.Value;
        }

        public static TMonth Load(int iDMonth)
        {
            TMonth result = new TMonth();
            result.LoadRecord(iDMonth);
            return result;
        }

        public static TMonth CachedLoad(int iDMonth)
        {
            DbCache.TableKey key = new DbCache.TableKey("TMonth");
            DbCache.CacheRecord record;
            key.Set(iDMonth);
            if (DbCache.Contains(key))
            {
                record = DbCache.GetRecord(key);
                if (!record.IsValid())
                {
                    record.Value = Load(iDMonth);
                    record.LastUpdate = DateTime.Now;
                    record.Valid = true;
                }
            }
            else
            {
                record = new DbCache.CacheRecord();
                record.Value = Load(iDMonth);
                record.LastUpdate = DateTime.Now;
                record.Valid = true;
                DbCache.SetRecord(key, record);
            }
            return (TMonth)record.Value;
        }

        public static TMonth Create()
        {
            TMonth result = new TMonth();
            result.LoadDefaultValues();
            return result;
        }

        public static DbTable<TMonth> LoadAll()
        {
            DbTable<TMonth> table = new DbTable<TMonth>();
            TMonth prototype = new TMonth();
            prototype.LoadTable(table);
            return table;
        }

        public static DbTable<TMonth> LoadBy(string whereCondition, params object[] parameterValues)
        {
            DbTable<TMonth> table = new DbTable<TMonth>();
            TMonth prototype = new TMonth();
            prototype.LoadTable(table, whereCondition, parameterValues);
            return table;
        }
    }

    public class TTypeDefect: DbObject
    {
        private static DbSchema schema = null;

        public int IDTypeDefect
        {
            get { return DbConverter.ToInt(this["IDTypeDefect"]); }
            set { this["IDTypeDefect"] = DbConverter.FromInt(value); }
        }

        public string TypeDefect
        {
            get { return DbConverter.ToString(this["TypeDefect"]); }
            set { this["TypeDefect"] = DbConverter.FromString(value); }
        }

        protected override DbSchema GetSchema()
        {
            if (schema == null)
            {
                schema = new DbSchema("TTypeDefect");
                schema.Add("IDTypeDefect", typeof(int), "IDTypeDefect", false, true, true);
                schema.Add("TypeDefect", typeof(string), "TypeDefect", false);
            }

            return schema;
        }

        public override void LoadDefaultValues()
        {
            SqlCommand command = Session.CreateCommand();

            this["IDTypeDefect"] = DbConverter.DefaultInt();

            this["TypeDefect"] = DbConverter.DefaultString();
        }

        public static TTypeDefect Load(int iDTypeDefect)
        {
            TTypeDefect result = new TTypeDefect();
            result.LoadRecord(iDTypeDefect);
            return result;
        }

        public static TTypeDefect CachedLoad(int iDTypeDefect)
        {
            DbCache.TableKey key = new DbCache.TableKey("TTypeDefect");
            DbCache.CacheRecord record;
            key.Set(iDTypeDefect);
            if (DbCache.Contains(key))
            {
                record = DbCache.GetRecord(key);
                if (!record.IsValid())
                {
                    record.Value = Load(iDTypeDefect);
                    record.LastUpdate = DateTime.Now;
                    record.Valid = true;
                }
            }
            else
            {
                record = new DbCache.CacheRecord();
                record.Value = Load(iDTypeDefect);
                record.LastUpdate = DateTime.Now;
                record.Valid = true;
                DbCache.SetRecord(key, record);
            }
            return (TTypeDefect)record.Value;
        }

        public static TTypeDefect Create()
        {
            TTypeDefect result = new TTypeDefect();
            result.LoadDefaultValues();
            return result;
        }

        public static DbTable<TTypeDefect> LoadAll()
        {
            DbTable<TTypeDefect> table = new DbTable<TTypeDefect>();
            TTypeDefect prototype = new TTypeDefect();
            prototype.LoadTable(table);
            return table;
        }

        public static DbTable<TTypeDefect> LoadBy(string whereCondition, params object[] parameterValues)
        {
            DbTable<TTypeDefect> table = new DbTable<TTypeDefect>();
            TTypeDefect prototype = new TTypeDefect();
            prototype.LoadTable(table, whereCondition, parameterValues);
            return table;
        }
    }

    public class TPersonResponsible: DbObject
    {
        private static DbSchema schema = null;

        public int IDPerson
        {
            get { return DbConverter.ToInt(this["IDPerson"]); }
            set { this["IDPerson"] = DbConverter.FromInt(value); }
        }

        public DbNullable<string> PersonName
        {
            get { return DbConverter.ToStringNull(this["PersonName"]); }
            set { this["PersonName"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> PersonLogin
        {
            get { return DbConverter.ToStringNull(this["PersonLogin"]); }
            set { this["PersonLogin"] = DbConverter.FromStringNull(value); }
        }

        protected override DbSchema GetSchema()
        {
            if (schema == null)
            {
                schema = new DbSchema("TPersonResponsible");
                schema.Add("IDPerson", typeof(int), "IDPerson", false, true, true);
                schema.Add("PersonName", typeof(string), "PersonName", true);
                schema.Add("PersonLogin", typeof(string), "PersonLogin", true);
            }

            return schema;
        }

        public override void LoadDefaultValues()
        {
            SqlCommand command = Session.CreateCommand();

            this["IDPerson"] = DbConverter.DefaultInt();

            this["PersonName"] = DBNull.Value;

            this["PersonLogin"] = DBNull.Value;
        }

        public static TPersonResponsible Load(int iDPerson)
        {
            TPersonResponsible result = new TPersonResponsible();
            result.LoadRecord(iDPerson);
            return result;
        }

        public static TPersonResponsible CachedLoad(int iDPerson)
        {
            DbCache.TableKey key = new DbCache.TableKey("TPersonResponsible");
            DbCache.CacheRecord record;
            key.Set(iDPerson);
            if (DbCache.Contains(key))
            {
                record = DbCache.GetRecord(key);
                if (!record.IsValid())
                {
                    record.Value = Load(iDPerson);
                    record.LastUpdate = DateTime.Now;
                    record.Valid = true;
                }
            }
            else
            {
                record = new DbCache.CacheRecord();
                record.Value = Load(iDPerson);
                record.LastUpdate = DateTime.Now;
                record.Valid = true;
                DbCache.SetRecord(key, record);
            }
            return (TPersonResponsible)record.Value;
        }

        public static TPersonResponsible Create()
        {
            TPersonResponsible result = new TPersonResponsible();
            result.LoadDefaultValues();
            return result;
        }

        public static DbTable<TPersonResponsible> LoadAll()
        {
            DbTable<TPersonResponsible> table = new DbTable<TPersonResponsible>();
            TPersonResponsible prototype = new TPersonResponsible();
            prototype.LoadTable(table);
            return table;
        }

        public static DbTable<TPersonResponsible> LoadBy(string whereCondition, params object[] parameterValues)
        {
            DbTable<TPersonResponsible> table = new DbTable<TPersonResponsible>();
            TPersonResponsible prototype = new TPersonResponsible();
            prototype.LoadTable(table, whereCondition, parameterValues);
            return table;
        }
    }

    public class TPlant: DbObject
    {
        private static DbSchema schema = null;

        public string Plant
        {
            get { return DbConverter.ToString(this["Plant"]); }
            set { this["Plant"] = DbConverter.FromString(value); }
        }

        public DbNullable<int> TimeComplaint
        {
            get { return DbConverter.ToIntNull(this["TimeComplaint"]); }
            set { this["TimeComplaint"] = DbConverter.FromIntNull(value); }
        }

        protected override DbSchema GetSchema()
        {
            if (schema == null)
            {
                schema = new DbSchema("TPlant");
                schema.Add("Plant", typeof(string), "Plant", false, true, false);
                schema.Add("TimeComplaint", typeof(int), "TimeComplaint", true);
            }

            return schema;
        }

        public override void LoadDefaultValues()
        {
            SqlCommand command = Session.CreateCommand();

            this["Plant"] = DbConverter.DefaultString();

            this["TimeComplaint"] = DBNull.Value;
        }

        public static TPlant Load(string plant)
        {
            TPlant result = new TPlant();
            result.LoadRecord(plant);
            return result;
        }

        public static TPlant CachedLoad(string plant)
        {
            DbCache.TableKey key = new DbCache.TableKey("TPlant");
            DbCache.CacheRecord record;
            key.Set(plant);
            if (DbCache.Contains(key))
            {
                record = DbCache.GetRecord(key);
                if (!record.IsValid())
                {
                    record.Value = Load(plant);
                    record.LastUpdate = DateTime.Now;
                    record.Valid = true;
                }
            }
            else
            {
                record = new DbCache.CacheRecord();
                record.Value = Load(plant);
                record.LastUpdate = DateTime.Now;
                record.Valid = true;
                DbCache.SetRecord(key, record);
            }
            return (TPlant)record.Value;
        }

        public static TPlant Create()
        {
            TPlant result = new TPlant();
            result.LoadDefaultValues();
            return result;
        }

        public static DbTable<TPlant> LoadAll()
        {
            DbTable<TPlant> table = new DbTable<TPlant>();
            TPlant prototype = new TPlant();
            prototype.LoadTable(table);
            return table;
        }

        public static DbTable<TPlant> LoadBy(string whereCondition, params object[] parameterValues)
        {
            DbTable<TPlant> table = new DbTable<TPlant>();
            TPlant prototype = new TPlant();
            prototype.LoadTable(table, whereCondition, parameterValues);
            return table;
        }
    }

    public class TComponents_2: DbObject
    {
        private static DbSchema schema = null;

        public int ComponentID
        {
            get { return DbConverter.ToInt(this["ComponentID"]); }
            set { this["ComponentID"] = DbConverter.FromInt(value); }
        }

        public string Code
        {
            get { return DbConverter.ToString(this["Code"]); }
            set { this["Code"] = DbConverter.FromString(value); }
        }

        public DbNullable<string> Vendor
        {
            get { return DbConverter.ToStringNull(this["Vendor"]); }
            set { this["Vendor"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> Description
        {
            get { return DbConverter.ToStringNull(this["Description"]); }
            set { this["Description"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<int> Supplier
        {
            get { return DbConverter.ToIntNull(this["Supplier"]); }
            set { this["Supplier"] = DbConverter.FromIntNull(value); }
        }

        public DbNullable<int> Manufacturer
        {
            get { return DbConverter.ToIntNull(this["Manufacturer"]); }
            set { this["Manufacturer"] = DbConverter.FromIntNull(value); }
        }

        public DbNullable<int> Responsible
        {
            get { return DbConverter.ToIntNull(this["Responsible"]); }
            set { this["Responsible"] = DbConverter.FromIntNull(value); }
        }

        public DbNullable<string> Issue
        {
            get { return DbConverter.ToStringNull(this["Issue"]); }
            set { this["Issue"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> Class
        {
            get { return DbConverter.ToStringNull(this["Class"]); }
            set { this["Class"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> CEMark
        {
            get { return DbConverter.ToStringNull(this["CEMark"]); }
            set { this["CEMark"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<DateTime> ExpiryDate
        {
            get { return DbConverter.ToDateTimeNull(this["ExpiryDate"]); }
            set { this["ExpiryDate"] = DbConverter.FromDateTimeNull(value); }
        }

        public DbNullable<string> CompatibleETO
        {
            get { return DbConverter.ToStringNull(this["CompatibleETO"]); }
            set { this["CompatibleETO"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> ProdApprov
        {
            get { return DbConverter.ToStringNull(this["ProdApprov"]); }
            set { this["ProdApprov"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> PhCheckInWareHouse
        {
            get { return DbConverter.ToStringNull(this["PhCheckInWareHouse"]); }
            set { this["PhCheckInWareHouse"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> Comments
        {
            get { return DbConverter.ToStringNull(this["Comments"]); }
            set { this["Comments"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> Questionnaire
        {
            get { return DbConverter.ToStringNull(this["Questionnaire"]); }
            set { this["Questionnaire"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<DateTime> SetUpDate
        {
            get { return DbConverter.ToDateTimeNull(this["SetUpDate"]); }
            set { this["SetUpDate"] = DbConverter.FromDateTimeNull(value); }
        }

        public DbNullable<DateTime> ApprovalDate
        {
            get { return DbConverter.ToDateTimeNull(this["ApprovalDate"]); }
            set { this["ApprovalDate"] = DbConverter.FromDateTimeNull(value); }
        }

        public DbNullable<DateTime> TrackingDate
        {
            get { return DbConverter.ToDateTimeNull(this["TrackingDate"]); }
            set { this["TrackingDate"] = DbConverter.FromDateTimeNull(value); }
        }

        public DbNullable<string> MaterComp
        {
            get { return DbConverter.ToStringNull(this["MaterComp"]); }
            set { this["MaterComp"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> PVC
        {
            get { return DbConverter.ToStringNull(this["PVC"]); }
            set { this["PVC"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> Phtalates
        {
            get { return DbConverter.ToStringNull(this["Phtalates"]); }
            set { this["Phtalates"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> LatexInComp
        {
            get { return DbConverter.ToStringNull(this["LatexInComp"]); }
            set { this["LatexInComp"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> LatexInPack
        {
            get { return DbConverter.ToStringNull(this["LatexInPack"]); }
            set { this["LatexInPack"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> Pyrogen
        {
            get { return DbConverter.ToStringNull(this["Pyrogen"]); }
            set { this["Pyrogen"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> StorageTemp
        {
            get { return DbConverter.ToStringNull(this["StorageTemp"]); }
            set { this["StorageTemp"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> OtherStorageCond
        {
            get { return DbConverter.ToStringNull(this["OtherStorageCond"]); }
            set { this["OtherStorageCond"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> MaxSterilVacuum
        {
            get { return DbConverter.ToStringNull(this["MaxSterilVacuum"]); }
            set { this["MaxSterilVacuum"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<int> PDMStatus
        {
            get { return DbConverter.ToIntNull(this["PDMStatus"]); }
            set { this["PDMStatus"] = DbConverter.FromIntNull(value); }
        }

        public DbNullable<DateTime> ProdApprovPDM
        {
            get { return DbConverter.ToDateTimeNull(this["ProdApprovPDM"]); }
            set { this["ProdApprovPDM"] = DbConverter.FromDateTimeNull(value); }
        }

        public DbNullable<string> TimeForApprov
        {
            get { return DbConverter.ToStringNull(this["TimeForApprov"]); }
            set { this["TimeForApprov"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> IntendedUse
        {
            get { return DbConverter.ToStringNull(this["IntendedUse"]); }
            set { this["IntendedUse"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<int> CheckedBy
        {
            get { return DbConverter.ToIntNull(this["CheckedBy"]); }
            set { this["CheckedBy"] = DbConverter.FromIntNull(value); }
        }

        public DbNullable<string> Material
        {
            get { return DbConverter.ToStringNull(this["Material"]); }
            set { this["Material"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<int> PDMStatusPhotoID
        {
            get { return DbConverter.ToIntNull(this["PDMStatusPhotoID"]); }
            set { this["PDMStatusPhotoID"] = DbConverter.FromIntNull(value); }
        }

        public DbNullable<string> KategorieKomponentu
        {
            get { return DbConverter.ToStringNull(this["KategorieKomponentu"]); }
            set { this["KategorieKomponentu"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> PDMComent
        {
            get { return DbConverter.ToStringNull(this["PDMComent"]); }
            set { this["PDMComent"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> Note
        {
            get { return DbConverter.ToStringNull(this["Note"]); }
            set { this["Note"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> SpecialNote
        {
            get { return DbConverter.ToStringNull(this["SpecialNote"]); }
            set { this["SpecialNote"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> BIN
        {
            get { return DbConverter.ToStringNull(this["BIN"]); }
            set { this["BIN"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> PcsBIN
        {
            get { return DbConverter.ToStringNull(this["PcsBIN"]); }
            set { this["PcsBIN"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<int> KomponentKategorieID
        {
            get { return DbConverter.ToIntNull(this["KomponentKategorieID"]); }
            set { this["KomponentKategorieID"] = DbConverter.FromIntNull(value); }
        }

        public DbNullable<DateTime> NafocenoKdy
        {
            get { return DbConverter.ToDateTimeNull(this["NafocenoKdy"]); }
            set { this["NafocenoKdy"] = DbConverter.FromDateTimeNull(value); }
        }

        public DbNullable<int> NafotilKdoID
        {
            get { return DbConverter.ToIntNull(this["NafotilKdoID"]); }
            set { this["NafotilKdoID"] = DbConverter.FromIntNull(value); }
        }

        public DbNullable<int> Pcs
        {
            get { return DbConverter.ToIntNull(this["Pcs"]); }
            set { this["Pcs"] = DbConverter.FromIntNull(value); }
        }

        public DbNullable<int> DostupnostID
        {
            get { return DbConverter.ToIntNull(this["DostupnostID"]); }
            set { this["DostupnostID"] = DbConverter.FromIntNull(value); }
        }

        public DbNullable<int> PohledT
        {
            get { return DbConverter.ToIntNull(this["PohledT"]); }
            set { this["PohledT"] = DbConverter.FromIntNull(value); }
        }

        public DbNullable<int> PohledTF
        {
            get { return DbConverter.ToIntNull(this["PohledTF"]); }
            set { this["PohledTF"] = DbConverter.FromIntNull(value); }
        }

        public DbNullable<int> PohledC
        {
            get { return DbConverter.ToIntNull(this["PohledC"]); }
            set { this["PohledC"] = DbConverter.FromIntNull(value); }
        }

        public DbNullable<int> PohledSpecial
        {
            get { return DbConverter.ToIntNull(this["PohledSpecial"]); }
            set { this["PohledSpecial"] = DbConverter.FromIntNull(value); }
        }

        public DbNullable<int> PohledCompics
        {
            get { return DbConverter.ToIntNull(this["PohledCompics"]); }
            set { this["PohledCompics"] = DbConverter.FromIntNull(value); }
        }

        public DbNullable<DateTime> _PrefocenoKdy
        {
            get { return DbConverter.ToDateTimeNull(this["_PrefocenoKdy"]); }
            set { this["_PrefocenoKdy"] = DbConverter.FromDateTimeNull(value); }
        }

        public DbNullable<string> EOD
        {
            get { return DbConverter.ToStringNull(this["EOD"]); }
            set { this["EOD"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<int> SCRAP
        {
            get { return DbConverter.ToIntNull(this["SCRAP"]); }
            set { this["SCRAP"] = DbConverter.FromIntNull(value); }
        }

        public DbNullable<DateTime> SCRAPdate
        {
            get { return DbConverter.ToDateTimeNull(this["SCRAPdate"]); }
            set { this["SCRAPdate"] = DbConverter.FromDateTimeNull(value); }
        }

        public DbNullable<string> ReasonSubst
        {
            get { return DbConverter.ToStringNull(this["ReasonSubst"]); }
            set { this["ReasonSubst"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<DateTime> Created
        {
            get { return DbConverter.ToDateTimeNull(this["Created"]); }
            set { this["Created"] = DbConverter.FromDateTimeNull(value); }
        }

        public DbNullable<string> CreatedBy
        {
            get { return DbConverter.ToStringNull(this["CreatedBy"]); }
            set { this["CreatedBy"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<DateTime> QuestionDate
        {
            get { return DbConverter.ToDateTimeNull(this["QuestionDate"]); }
            set { this["QuestionDate"] = DbConverter.FromDateTimeNull(value); }
        }

        public DbNullable<int> QuestionStatus
        {
            get { return DbConverter.ToIntNull(this["QuestionStatus"]); }
            set { this["QuestionStatus"] = DbConverter.FromIntNull(value); }
        }

        public DbNullable<string> Residuals
        {
            get { return DbConverter.ToStringNull(this["Residuals"]); }
            set { this["Residuals"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> VendorPhoto
        {
            get { return DbConverter.ToStringNull(this["VendorPhoto"]); }
            set { this["VendorPhoto"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<DateTime> ZmenaDatum
        {
            get { return DbConverter.ToDateTimeNull(this["ZmenaDatum"]); }
            set { this["ZmenaDatum"] = DbConverter.FromDateTimeNull(value); }
        }

        public DbNullable<string> ZmenaPozn
        {
            get { return DbConverter.ToStringNull(this["ZmenaPozn"]); }
            set { this["ZmenaPozn"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<decimal> Vaha
        {
            get { return DbConverter.ToDecimalNull(this["Vaha"]); }
            set { this["Vaha"] = DbConverter.FromDecimalNull(value); }
        }

        public DbNullable<string> VahaPoznamka
        {
            get { return DbConverter.ToStringNull(this["VahaPoznamka"]); }
            set { this["VahaPoznamka"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<int> PcsBIN2
        {
            get { return DbConverter.ToIntNull(this["PcsBIN2"]); }
            set { this["PcsBIN2"] = DbConverter.FromIntNull(value); }
        }

        public bool Checked
        {
            get { return DbConverter.ToBool(this["Checked"]); }
            set { this["Checked"] = DbConverter.FromBool(value); }
        }

        public DbNullable<int> VP
        {
            get { return DbConverter.ToIntNull(this["VP"]); }
            set { this["VP"] = DbConverter.FromIntNull(value); }
        }

        public DbNullable<int> FyzickaKontrola
        {
            get { return DbConverter.ToIntNull(this["FyzickaKontrola"]); }
            set { this["FyzickaKontrola"] = DbConverter.FromIntNull(value); }
        }

        public DbNullable<int> VzorovyKomponent
        {
            get { return DbConverter.ToIntNull(this["VzorovyKomponent"]); }
            set { this["VzorovyKomponent"] = DbConverter.FromIntNull(value); }
        }

        public DbNullable<int> KontrolaFotek
        {
            get { return DbConverter.ToIntNull(this["KontrolaFotek"]); }
            set { this["KontrolaFotek"] = DbConverter.FromIntNull(value); }
        }

        public DbNullable<int> Kprefoceni
        {
            get { return DbConverter.ToIntNull(this["Kprefoceni"]); }
            set { this["Kprefoceni"] = DbConverter.FromIntNull(value); }
        }

        public DbNullable<int> New
        {
            get { return DbConverter.ToIntNull(this["New"]); }
            set { this["New"] = DbConverter.FromIntNull(value); }
        }

        public DbNullable<int> Exter
        {
            get { return DbConverter.ToIntNull(this["Exter"]); }
            set { this["Exter"] = DbConverter.FromIntNull(value); }
        }

        public bool ZmenaDesignu
        {
            get { return DbConverter.ToBool(this["ZmenaDesignu"]); }
            set { this["ZmenaDesignu"] = DbConverter.FromBool(value); }
        }

        public bool TimeRevision
        {
            get { return DbConverter.ToBool(this["TimeRevision"]); }
            set { this["TimeRevision"] = DbConverter.FromBool(value); }
        }

        protected override DbSchema GetSchema()
        {
            if (schema == null)
            {
                schema = new DbSchema("TComponents_2");
                schema.Add("ComponentID", typeof(int), "ComponentID", false, true, true);
                schema.Add("Code", typeof(string), "Code", false);
                schema.Add("Vendor", typeof(string), "Vendor", true);
                schema.Add("Description", typeof(string), "Description", true);
                schema.Add("Supplier", typeof(int), "Supplier", true);
                schema.Add("Manufacturer", typeof(int), "Manufacturer", true);
                schema.Add("Responsible", typeof(int), "Responsible", true);
                schema.Add("Issue", typeof(string), "Issue", true);
                schema.Add("Class", typeof(string), "Class", true);
                schema.Add("CEMark", typeof(string), "CEMark", true);
                schema.Add("ExpiryDate", typeof(DateTime), "ExpiryDate", true);
                schema.Add("CompatibleETO", typeof(string), "CompatibleETO", true);
                schema.Add("ProdApprov", typeof(string), "ProdApprov", true);
                schema.Add("PhCheckInWareHouse", typeof(string), "PhCheckInWareHouse", true);
                schema.Add("Comments", typeof(string), "Comments", true);
                schema.Add("Questionnaire", typeof(string), "Questionnaire", true);
                schema.Add("SetUpDate", typeof(DateTime), "SetUpDate", true);
                schema.Add("ApprovalDate", typeof(DateTime), "ApprovalDate", true);
                schema.Add("TrackingDate", typeof(DateTime), "TrackingDate", true);
                schema.Add("MaterComp", typeof(string), "MaterComp", true);
                schema.Add("PVC", typeof(string), "PVC", true);
                schema.Add("Phtalates", typeof(string), "Phtalates", true);
                schema.Add("LatexInComp", typeof(string), "LatexInComp", true);
                schema.Add("LatexInPack", typeof(string), "LatexInPack", true);
                schema.Add("Pyrogen", typeof(string), "Pyrogen", true);
                schema.Add("StorageTemp", typeof(string), "StorageTemp", true);
                schema.Add("OtherStorageCond", typeof(string), "OtherStorageCond", true);
                schema.Add("MaxSterilVacuum", typeof(string), "MaxSterilVacuum", true);
                schema.Add("PDMStatus", typeof(int), "PDMStatus", true);
                schema.Add("ProdApprovPDM", typeof(DateTime), "ProdApprovPDM", true);
                schema.Add("TimeForApprov", typeof(string), "TimeForApprov", true);
                schema.Add("IntendedUse", typeof(string), "IntendedUse", true);
                schema.Add("CheckedBy", typeof(int), "CheckedBy", true);
                schema.Add("Material", typeof(string), "Material", true);
                schema.Add("PDMStatusPhotoID", typeof(int), "PDMStatusPhotoID", true);
                schema.Add("KategorieKomponentu", typeof(string), "KategorieKomponentu", true);
                schema.Add("PDMComent", typeof(string), "PDMComent", true);
                schema.Add("Note", typeof(string), "Note", true);
                schema.Add("SpecialNote", typeof(string), "SpecialNote", true);
                schema.Add("BIN", typeof(string), "BIN", true);
                schema.Add("PcsBIN", typeof(string), "PcsBIN", true);
                schema.Add("KomponentKategorieID", typeof(int), "KomponentKategorieID", true);
                schema.Add("NafocenoKdy", typeof(DateTime), "NafocenoKdy", true);
                schema.Add("NafotilKdoID", typeof(int), "NafotilKdoID", true);
                schema.Add("Pcs", typeof(int), "Pcs", true);
                schema.Add("DostupnostID", typeof(int), "DostupnostID", true);
                schema.Add("PohledT", typeof(int), "PohledT", true);
                schema.Add("PohledTF", typeof(int), "PohledTF", true);
                schema.Add("PohledC", typeof(int), "PohledC", true);
                schema.Add("PohledSpecial", typeof(int), "PohledSpecial", true);
                schema.Add("PohledCompics", typeof(int), "PohledCompics", true);
                schema.Add("_PrefocenoKdy", typeof(DateTime), "_PrefocenoKdy", true);
                schema.Add("EOD", typeof(string), "EOD", true);
                schema.Add("SCRAP", typeof(int), "SCRAP", true);
                schema.Add("SCRAPdate", typeof(DateTime), "SCRAPdate", true);
                schema.Add("ReasonSubst", typeof(string), "ReasonSubst", true);
                schema.Add("Created", typeof(DateTime), "Created", true);
                schema.Add("CreatedBy", typeof(string), "CreatedBy", true);
                schema.Add("QuestionDate", typeof(DateTime), "QuestionDate", true);
                schema.Add("QuestionStatus", typeof(int), "QuestionStatus", true);
                schema.Add("Residuals", typeof(string), "Residuals", true);
                schema.Add("VendorPhoto", typeof(string), "VendorPhoto", true);
                schema.Add("ZmenaDatum", typeof(DateTime), "ZmenaDatum", true);
                schema.Add("ZmenaPozn", typeof(string), "ZmenaPozn", true);
                schema.Add("Vaha", typeof(decimal), "Vaha", true);
                schema.Add("VahaPoznamka", typeof(string), "VahaPoznamka", true);
                schema.Add("PcsBIN2", typeof(int), "PcsBIN2", true);
                schema.Add("Checked", typeof(bool), "Checked", false);
                schema.Add("VP", typeof(int), "VP", true);
                schema.Add("FyzickaKontrola", typeof(int), "FyzickaKontrola", true);
                schema.Add("VzorovyKomponent", typeof(int), "VzorovyKomponent", true);
                schema.Add("KontrolaFotek", typeof(int), "KontrolaFotek", true);
                schema.Add("Kprefoceni", typeof(int), "Kprefoceni", true);
                schema.Add("New", typeof(int), "New", true);
                schema.Add("Exter", typeof(int), "Exter", true);
                schema.Add("ZmenaDesignu", typeof(bool), "ZmenaDesignu", false);
                schema.Add("TimeRevision", typeof(bool), "TimeRevision", false);
            }

            return schema;
        }

        public override void LoadDefaultValues()
        {
            SqlCommand command = Session.CreateCommand();

            this["ComponentID"] = DbConverter.DefaultInt();

            this["Code"] = DbConverter.DefaultString();

            this["Vendor"] = DBNull.Value;

            this["Description"] = DBNull.Value;

            this["Supplier"] = DBNull.Value;

            this["Manufacturer"] = DBNull.Value;

            this["Responsible"] = DBNull.Value;

            this["Issue"] = DBNull.Value;

            this["Class"] = DBNull.Value;

            this["CEMark"] = DBNull.Value;

            this["ExpiryDate"] = DBNull.Value;

            this["CompatibleETO"] = DBNull.Value;

            this["ProdApprov"] = DBNull.Value;

            this["PhCheckInWareHouse"] = DBNull.Value;

            this["Comments"] = DBNull.Value;

            this["Questionnaire"] = DBNull.Value;

            this["SetUpDate"] = DBNull.Value;

            this["ApprovalDate"] = DBNull.Value;

            this["TrackingDate"] = DBNull.Value;

            this["MaterComp"] = DBNull.Value;

            this["PVC"] = DBNull.Value;

            this["Phtalates"] = DBNull.Value;

            this["LatexInComp"] = DBNull.Value;

            this["LatexInPack"] = DBNull.Value;

            this["Pyrogen"] = DBNull.Value;

            this["StorageTemp"] = DBNull.Value;

            this["OtherStorageCond"] = DBNull.Value;

            this["MaxSterilVacuum"] = DBNull.Value;

            this["PDMStatus"] = DBNull.Value;

            this["ProdApprovPDM"] = DBNull.Value;

            this["TimeForApprov"] = DBNull.Value;

            this["IntendedUse"] = DBNull.Value;

            this["CheckedBy"] = DBNull.Value;

            this["Material"] = DBNull.Value;

            this["PDMStatusPhotoID"] = DBNull.Value;

            this["KategorieKomponentu"] = DBNull.Value;

            this["PDMComent"] = DBNull.Value;

            this["Note"] = DBNull.Value;

            this["SpecialNote"] = DBNull.Value;

            this["BIN"] = DBNull.Value;

            this["PcsBIN"] = DBNull.Value;

            this["KomponentKategorieID"] = DBNull.Value;

            this["NafocenoKdy"] = DBNull.Value;

            this["NafotilKdoID"] = DBNull.Value;

            this["Pcs"] = DBNull.Value;

            this["DostupnostID"] = DBNull.Value;

            this["PohledT"] = DBNull.Value;

            this["PohledTF"] = DBNull.Value;

            this["PohledC"] = DBNull.Value;

            this["PohledSpecial"] = DBNull.Value;

            this["PohledCompics"] = DBNull.Value;

            this["_PrefocenoKdy"] = DBNull.Value;

            this["EOD"] = DBNull.Value;

            this["SCRAP"] = DBNull.Value;

            this["SCRAPdate"] = DBNull.Value;

            this["ReasonSubst"] = DBNull.Value;

            this["Created"] = DBNull.Value;

            this["CreatedBy"] = DBNull.Value;

            this["QuestionDate"] = DBNull.Value;

            this["QuestionStatus"] = DBNull.Value;

            this["Residuals"] = DBNull.Value;

            this["VendorPhoto"] = DBNull.Value;

            this["ZmenaDatum"] = DBNull.Value;

            this["ZmenaPozn"] = DBNull.Value;

            this["Vaha"] = DBNull.Value;

            this["VahaPoznamka"] = DBNull.Value;

            this["PcsBIN2"] = DBNull.Value;

            command.CommandText = "SELECT ((1))";
            this["Checked"] = command.ExecuteScalar();

            this["VP"] = DBNull.Value;

            this["FyzickaKontrola"] = DBNull.Value;

            this["VzorovyKomponent"] = DBNull.Value;

            this["KontrolaFotek"] = DBNull.Value;

            this["Kprefoceni"] = DBNull.Value;

            this["New"] = DBNull.Value;

            this["Exter"] = DBNull.Value;

            command.CommandText = "SELECT ((0))";
            this["ZmenaDesignu"] = command.ExecuteScalar();

            command.CommandText = "SELECT ((0))";
            this["TimeRevision"] = command.ExecuteScalar();
        }

        public static TComponents_2 Load(int componentID)
        {
            TComponents_2 result = new TComponents_2();
            result.LoadRecord(componentID);
            return result;
        }

        public static TComponents_2 CachedLoad(int componentID)
        {
            DbCache.TableKey key = new DbCache.TableKey("TComponents_2");
            DbCache.CacheRecord record;
            key.Set(componentID);
            if (DbCache.Contains(key))
            {
                record = DbCache.GetRecord(key);
                if (!record.IsValid())
                {
                    record.Value = Load(componentID);
                    record.LastUpdate = DateTime.Now;
                    record.Valid = true;
                }
            }
            else
            {
                record = new DbCache.CacheRecord();
                record.Value = Load(componentID);
                record.LastUpdate = DateTime.Now;
                record.Valid = true;
                DbCache.SetRecord(key, record);
            }
            return (TComponents_2)record.Value;
        }

        public static TComponents_2 Create()
        {
            TComponents_2 result = new TComponents_2();
            result.LoadDefaultValues();
            return result;
        }

        public static DbTable<TComponents_2> LoadAll()
        {
            DbTable<TComponents_2> table = new DbTable<TComponents_2>();
            TComponents_2 prototype = new TComponents_2();
            prototype.LoadTable(table);
            return table;
        }

        public static DbTable<TComponents_2> LoadBy(string whereCondition, params object[] parameterValues)
        {
            DbTable<TComponents_2> table = new DbTable<TComponents_2>();
            TComponents_2 prototype = new TComponents_2();
            prototype.LoadTable(table, whereCondition, parameterValues);
            return table;
        }
    }

    public class TStatus: DbObject
    {
        private static DbSchema schema = null;

        public int IDStatus
        {
            get { return DbConverter.ToInt(this["IDStatus"]); }
            set { this["IDStatus"] = DbConverter.FromInt(value); }
        }

        public DbNullable<string> Status
        {
            get { return DbConverter.ToStringNull(this["Status"]); }
            set { this["Status"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<int> StatusOrder
        {
            get { return DbConverter.ToIntNull(this["StatusOrder"]); }
            set { this["StatusOrder"] = DbConverter.FromIntNull(value); }
        }

        protected override DbSchema GetSchema()
        {
            if (schema == null)
            {
                schema = new DbSchema("TStatus");
                schema.Add("IDStatus", typeof(int), "IDStatus", false, true, true);
                schema.Add("Status", typeof(string), "Status", true);
                schema.Add("StatusOrder", typeof(int), "StatusOrder", true);
            }

            return schema;
        }

        public override void LoadDefaultValues()
        {
            SqlCommand command = Session.CreateCommand();

            this["IDStatus"] = DbConverter.DefaultInt();

            this["Status"] = DBNull.Value;

            this["StatusOrder"] = DBNull.Value;
        }

        public static TStatus Load(int iDStatus)
        {
            TStatus result = new TStatus();
            result.LoadRecord(iDStatus);
            return result;
        }

        public static TStatus CachedLoad(int iDStatus)
        {
            DbCache.TableKey key = new DbCache.TableKey("TStatus");
            DbCache.CacheRecord record;
            key.Set(iDStatus);
            if (DbCache.Contains(key))
            {
                record = DbCache.GetRecord(key);
                if (!record.IsValid())
                {
                    record.Value = Load(iDStatus);
                    record.LastUpdate = DateTime.Now;
                    record.Valid = true;
                }
            }
            else
            {
                record = new DbCache.CacheRecord();
                record.Value = Load(iDStatus);
                record.LastUpdate = DateTime.Now;
                record.Valid = true;
                DbCache.SetRecord(key, record);
            }
            return (TStatus)record.Value;
        }

        public static TStatus Create()
        {
            TStatus result = new TStatus();
            result.LoadDefaultValues();
            return result;
        }

        public static DbTable<TStatus> LoadAll()
        {
            DbTable<TStatus> table = new DbTable<TStatus>();
            TStatus prototype = new TStatus();
            prototype.LoadTable(table);
            return table;
        }

        public static DbTable<TStatus> LoadBy(string whereCondition, params object[] parameterValues)
        {
            DbTable<TStatus> table = new DbTable<TStatus>();
            TStatus prototype = new TStatus();
            prototype.LoadTable(table, whereCondition, parameterValues);
            return table;
        }
    }

    public class TSampleListCis: DbObject
    {
        private static DbSchema schema = null;

        public int ID
        {
            get { return DbConverter.ToInt(this["ID"]); }
            set { this["ID"] = DbConverter.FromInt(value); }
        }

        public DbNullable<string> SCategory
        {
            get { return DbConverter.ToStringNull(this["SCategory"]); }
            set { this["SCategory"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> Name
        {
            get { return DbConverter.ToStringNull(this["Name"]); }
            set { this["Name"] = DbConverter.FromStringNull(value); }
        }

        protected override DbSchema GetSchema()
        {
            if (schema == null)
            {
                schema = new DbSchema("TSampleListCis");
                schema.Add("ID", typeof(int), "ID", false, true, true);
                schema.Add("SCategory", typeof(string), "SCategory", true);
                schema.Add("Name", typeof(string), "Name", true);
            }

            return schema;
        }

        public override void LoadDefaultValues()
        {
            SqlCommand command = Session.CreateCommand();

            this["ID"] = DbConverter.DefaultInt();

            this["SCategory"] = DBNull.Value;

            this["Name"] = DBNull.Value;
        }

        public static TSampleListCis Load(int iD)
        {
            TSampleListCis result = new TSampleListCis();
            result.LoadRecord(iD);
            return result;
        }

        public static TSampleListCis CachedLoad(int iD)
        {
            DbCache.TableKey key = new DbCache.TableKey("TSampleListCis");
            DbCache.CacheRecord record;
            key.Set(iD);
            if (DbCache.Contains(key))
            {
                record = DbCache.GetRecord(key);
                if (!record.IsValid())
                {
                    record.Value = Load(iD);
                    record.LastUpdate = DateTime.Now;
                    record.Valid = true;
                }
            }
            else
            {
                record = new DbCache.CacheRecord();
                record.Value = Load(iD);
                record.LastUpdate = DateTime.Now;
                record.Valid = true;
                DbCache.SetRecord(key, record);
            }
            return (TSampleListCis)record.Value;
        }

        public static TSampleListCis Create()
        {
            TSampleListCis result = new TSampleListCis();
            result.LoadDefaultValues();
            return result;
        }

        public static DbTable<TSampleListCis> LoadAll()
        {
            DbTable<TSampleListCis> table = new DbTable<TSampleListCis>();
            TSampleListCis prototype = new TSampleListCis();
            prototype.LoadTable(table);
            return table;
        }

        public static DbTable<TSampleListCis> LoadBy(string whereCondition, params object[] parameterValues)
        {
            DbTable<TSampleListCis> table = new DbTable<TSampleListCis>();
            TSampleListCis prototype = new TSampleListCis();
            prototype.LoadTable(table, whereCondition, parameterValues);
            return table;
        }
    }

    public class TAttachments: DbObject
    {
        private static DbSchema schema = null;

        public int IDAttachment
        {
            get { return DbConverter.ToInt(this["IDAttachment"]); }
            set { this["IDAttachment"] = DbConverter.FromInt(value); }
        }

        public DbNullable<string> AttName
        {
            get { return DbConverter.ToStringNull(this["AttName"]); }
            set { this["AttName"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> AttPath
        {
            get { return DbConverter.ToStringNull(this["AttPath"]); }
            set { this["AttPath"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<DateTime> Created
        {
            get { return DbConverter.ToDateTimeNull(this["Created"]); }
            set { this["Created"] = DbConverter.FromDateTimeNull(value); }
        }

        public DbNullable<string> CreatedBy
        {
            get { return DbConverter.ToStringNull(this["CreatedBy"]); }
            set { this["CreatedBy"] = DbConverter.FromStringNull(value); }
        }

        protected override DbSchema GetSchema()
        {
            if (schema == null)
            {
                schema = new DbSchema("TAttachments");
                schema.Add("IDAttachment", typeof(int), "IDAttachment", false, true, true);
                schema.Add("AttName", typeof(string), "AttName", true);
                schema.Add("AttPath", typeof(string), "AttPath", true);
                schema.Add("Created", typeof(DateTime), "Created", true);
                schema.Add("CreatedBy", typeof(string), "CreatedBy", true);
            }

            return schema;
        }

        public override void LoadDefaultValues()
        {
            SqlCommand command = Session.CreateCommand();

            this["IDAttachment"] = DbConverter.DefaultInt();

            this["AttName"] = DBNull.Value;

            this["AttPath"] = DBNull.Value;

            command.CommandText = "SELECT (getdate())";
            this["Created"] = command.ExecuteScalar();

            command.CommandText = "SELECT ([dbo].[FceUserMSSQL]())";
            this["CreatedBy"] = command.ExecuteScalar();
        }

        public static TAttachments Load(int iDAttachment)
        {
            TAttachments result = new TAttachments();
            result.LoadRecord(iDAttachment);
            return result;
        }

        public static TAttachments CachedLoad(int iDAttachment)
        {
            DbCache.TableKey key = new DbCache.TableKey("TAttachments");
            DbCache.CacheRecord record;
            key.Set(iDAttachment);
            if (DbCache.Contains(key))
            {
                record = DbCache.GetRecord(key);
                if (!record.IsValid())
                {
                    record.Value = Load(iDAttachment);
                    record.LastUpdate = DateTime.Now;
                    record.Valid = true;
                }
            }
            else
            {
                record = new DbCache.CacheRecord();
                record.Value = Load(iDAttachment);
                record.LastUpdate = DateTime.Now;
                record.Valid = true;
                DbCache.SetRecord(key, record);
            }
            return (TAttachments)record.Value;
        }

        public static TAttachments Create()
        {
            TAttachments result = new TAttachments();
            result.LoadDefaultValues();
            return result;
        }

        public static DbTable<TAttachments> LoadAll()
        {
            DbTable<TAttachments> table = new DbTable<TAttachments>();
            TAttachments prototype = new TAttachments();
            prototype.LoadTable(table);
            return table;
        }

        public static DbTable<TAttachments> LoadBy(string whereCondition, params object[] parameterValues)
        {
            DbTable<TAttachments> table = new DbTable<TAttachments>();
            TAttachments prototype = new TAttachments();
            prototype.LoadTable(table, whereCondition, parameterValues);
            return table;
        }
    }

    public class TYear: DbObject
    {
        private static DbSchema schema = null;

        public int Year
        {
            get { return DbConverter.ToInt(this["Year"]); }
            set { this["Year"] = DbConverter.FromInt(value); }
        }

        protected override DbSchema GetSchema()
        {
            if (schema == null)
            {
                schema = new DbSchema("TYear");
                schema.Add("Year", typeof(int), "Year", false, true, false);
            }

            return schema;
        }

        public override void LoadDefaultValues()
        {
            SqlCommand command = Session.CreateCommand();

            this["Year"] = DbConverter.DefaultInt();
        }

        public static TYear Load(int year)
        {
            TYear result = new TYear();
            result.LoadRecord(year);
            return result;
        }

        public static TYear CachedLoad(int year)
        {
            DbCache.TableKey key = new DbCache.TableKey("TYear");
            DbCache.CacheRecord record;
            key.Set(year);
            if (DbCache.Contains(key))
            {
                record = DbCache.GetRecord(key);
                if (!record.IsValid())
                {
                    record.Value = Load(year);
                    record.LastUpdate = DateTime.Now;
                    record.Valid = true;
                }
            }
            else
            {
                record = new DbCache.CacheRecord();
                record.Value = Load(year);
                record.LastUpdate = DateTime.Now;
                record.Valid = true;
                DbCache.SetRecord(key, record);
            }
            return (TYear)record.Value;
        }

        public static TYear Create()
        {
            TYear result = new TYear();
            result.LoadDefaultValues();
            return result;
        }

        public static DbTable<TYear> LoadAll()
        {
            DbTable<TYear> table = new DbTable<TYear>();
            TYear prototype = new TYear();
            prototype.LoadTable(table);
            return table;
        }

        public static DbTable<TYear> LoadBy(string whereCondition, params object[] parameterValues)
        {
            DbTable<TYear> table = new DbTable<TYear>();
            TYear prototype = new TYear();
            prototype.LoadTable(table, whereCondition, parameterValues);
            return table;
        }
    }

    public class ImportTimes: DbObject
    {
        private static DbSchema schema = null;

        public DbNullable<string> status_komponentu
        {
            get { return DbConverter.ToStringNull(this["status komponentu"]); }
            set { this["status komponentu"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> číslo_komponentu
        {
            get { return DbConverter.ToStringNull(this["číslo komponentu"]); }
            set { this["číslo komponentu"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> Druh_komponentu
        {
            get { return DbConverter.ToStringNull(this["Druh komponentu"]); }
            set { this["Druh komponentu"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> interní_komponetář
        {
            get { return DbConverter.ToStringNull(this["interní komponetář"]); }
            set { this["interní komponetář"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> datum_nafocení
        {
            get { return DbConverter.ToStringNull(this["datum nafocení"]); }
            set { this["datum nafocení"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> Hlavní_komponent
        {
            get { return DbConverter.ToStringNull(this["Hlavní komponent"]); }
            set { this["Hlavní komponent"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> IFU
        {
            get { return DbConverter.ToStringNull(this["IFU"]); }
            set { this["IFU"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> Oprava_komponentu
        {
            get { return DbConverter.ToStringNull(this["Oprava komponentu"]); }
            set { this["Oprava komponentu"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> Detail_opravy_komponentu
        {
            get { return DbConverter.ToStringNull(this["Detail opravy komponentu"]); }
            set { this["Detail opravy komponentu"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> způsob_vyskladnění
        {
            get { return DbConverter.ToStringNull(this["způsob vyskladnění"]); }
            set { this["způsob vyskladnění"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> překontrolovat_balení
        {
            get { return DbConverter.ToStringNull(this["překontrolovat balení"]); }
            set { this["překontrolovat balení"] = DbConverter.FromStringNull(value); }
        }

        //TODO - otaznik WTF
        public DbNullable<string> Je_potřeba_čas_revidovat
        {
            get { return DbConverter.ToStringNull(this["Je potřeba čas revidovat"]); }
            set { this["Je potřeba čas revidovat? "] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<double> Revize_MOST
        {
            get { return DbConverter.ToDoubleNull(this["Revize MOST"]); }
            set { this["Revize MOST"] = DbConverter.FromDoubleNull(value); }
        }

        public DbNullable<string> SAP
        {
            get { return DbConverter.ToStringNull(this["SAP"]); }
            set { this["SAP"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> CW
        {
            get { return DbConverter.ToStringNull(this["CW"]); }
            set { this["CW"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> LF
        {
            get { return DbConverter.ToStringNull(this["LF"]); }
            set { this["LF"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> Starý_formulář
        {
            get { return DbConverter.ToStringNull(this["Starý formulář"]); }
            set { this["Starý formulář"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<double> IMAGE
        {
            get { return DbConverter.ToDoubleNull(this["IMAGE"]); }
            set { this["IMAGE"] = DbConverter.FromDoubleNull(value); }
        }

        // TODO - Vychystávání_-sklad________VS
        public DbNullable<double> Vychystávání_sklad________VS
        {
            get { return DbConverter.ToDoubleNull(this["Vychystávání sklad        VS"]); }
            set { this["Vychystávání sklad        VS"] = DbConverter.FromDoubleNull(value); }
        }

        // TODO Vychystávání_-výroba_____VV
        public DbNullable<double> Vychystávání_výroba_____VV
        {
            get { return DbConverter.ToDoubleNull(this["Vychystávání výroba     VV"]); }
            set { this["Vychystávání výroba     VV"] = DbConverter.FromDoubleNull(value); }
        }

        // TODO Vychystávání_výroba_-manipulace____VM
        public DbNullable<double> Vychystávání_výroba_manipulace____VM
        {
            get { return DbConverter.ToDoubleNull(this["Vychystávání výroba manipulace    VM"]); }
            set { this["Vychystávání výroba manipulace    VM"] = DbConverter.FromDoubleNull(value); }
        }

        // TODO Vychystávání_výroba-předkompletace____VP
        public DbNullable<double> Vychystávání_výrobapředkompletace____VP
        {
            get { return DbConverter.ToDoubleNull(this["Vychystávání výrobapředkompletace    VP"]); }
            set { this["Vychystávání výroba-předkompletace    VP"] = DbConverter.FromDoubleNull(value); }
        }

        public DbNullable<double> Vychystávání__________Vx
        {
            get { return DbConverter.ToDoubleNull(this["Vychystávání          Vx"]); }
            set { this["Vychystávání          Vx"] = DbConverter.FromDoubleNull(value); }
        }

        public DbNullable<double> Přípravné_činnosti____PP
        {
            get { return DbConverter.ToDoubleNull(this["Přípravné činnosti    PP"]); }
            set { this["Přípravné činnosti    PP"] = DbConverter.FromDoubleNull(value); }
        }

        public DbNullable<double> Manipulační_činnosti___PM
        {
            get { return DbConverter.ToDoubleNull(this["Manipulační činnosti   PM"]); }
            set { this["Manipulační činnosti   PM"] = DbConverter.FromDoubleNull(value); }
        }

        public DbNullable<double> Výroba___Px
        {
            get { return DbConverter.ToDoubleNull(this["Výroba   Px"]); }
            set { this["Výroba   Px"] = DbConverter.FromDoubleNull(value); }
        }

        public DbNullable<double> Kompletace___K
        {
            get { return DbConverter.ToDoubleNull(this["Kompletace   K"]); }
            set { this["Kompletace   K"] = DbConverter.FromDoubleNull(value); }
        }

        // TODO Routing__(s/ks)
        public DbNullable<double> Routing__sKs
        {
            get { return DbConverter.ToDoubleNull(this["Routing  sKs"]); }
            set { this["Routing  sKs"] = DbConverter.FromDoubleNull(value); }
        }

        public DbNullable<double> Čas_pro_SAP
        {
            get { return DbConverter.ToDoubleNull(this["Čas pro SAP"]); }
            set { this["Čas pro SAP"] = DbConverter.FromDoubleNull(value); }
        }

        public DbNullable<double> stejný_čas_jako_image
        {
            get { return DbConverter.ToDoubleNull(this["stejný čas jako image"]); }
            set { this["stejný čas jako image"] = DbConverter.FromDoubleNull(value); }
        }

        // TODO counter_no_(do_Z-tabulek)TOTO_JE_NYNÍ_V_SAPU
        public DbNullable<double> counter_no_do_Z_tabulek_TOTO_JE_NYNÍ_V_SAPU
        {
            get { return DbConverter.ToDoubleNull(this["counter_no_do_Z_tabulek_TOTO_JE_NYNÍ_V_SAPU"]); }
            set { this["counter_no_do_Z_tabulek_TOTO_JE_NYNÍ_V_SAPU"] = DbConverter.FromDoubleNull(value); }
        }

        public DbNullable<string> datum_pro_export_a_aktualizaci
        {
            get { return DbConverter.ToStringNull(this["datum pro export a aktualizaci"]); }
            set { this["datum pro export a aktualizaci"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> aktuální_Most_formulář
        {
            get { return DbConverter.ToStringNull(this["aktuální Most formulář"]); }
            set { this["aktuální Most formulář"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> Poznámky_ke_komponentu
        {
            get { return DbConverter.ToStringNull(this["Poznámky ke komponentu"]); }
            set { this["Poznámky ke komponentu"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<double> Přirážka
        {
            get { return DbConverter.ToDoubleNull(this["Přirážka"]); }
            set { this["Přirážka"] = DbConverter.FromDoubleNull(value); }
        }

        public DbNullable<string> F36
        {
            get { return DbConverter.ToStringNull(this["F36"]); }
            set { this["F36"] = DbConverter.FromStringNull(value); }
        }

        protected override DbSchema GetSchema()
        {
            if (schema == null)
            {
                schema = new DbSchema("ImportTimes");
                schema.Add("status komponentu", typeof(string), "status komponentu", true);
                schema.Add("číslo komponentu", typeof(string), "číslo komponentu", true);
                schema.Add("Druh komponentu", typeof(string), "Druh komponentu", true);
                schema.Add("interní komponetář", typeof(string), "interní komponetář", true);
                schema.Add("datum nafocení", typeof(string), "datum nafocení", true);
                schema.Add("Hlavní komponent", typeof(string), "Hlavní komponent", true);
                schema.Add("IFU", typeof(string), "IFU", true);
                schema.Add("Oprava komponentu", typeof(string), "Oprava komponentu", true);
                schema.Add("Detail opravy komponentu", typeof(string), "Detail opravy komponentu", true);
                schema.Add("způsob vyskladnění", typeof(string), "způsob vyskladnění", true);
                schema.Add("překontrolovat balení", typeof(string), "překontrolovat balení", true);
                schema.Add("Je potřeba čas revidovat? ", typeof(string), "Je potřeba čas revidovat? ", true);
                schema.Add("Revize MOST", typeof(double), "Revize MOST", true);
                schema.Add("SAP", typeof(string), "SAP", true);
                schema.Add("CW", typeof(string), "CW", true);
                schema.Add("LF", typeof(string), "LF", true);
                schema.Add("Starý formulář", typeof(string), "Starý formulář", true);
                schema.Add("IMAGE", typeof(double), "IMAGE", true);
                schema.Add("Vychystávání -sklad        VS", typeof(double), "Vychystávání -sklad        VS", true);
                schema.Add("Vychystávání -výroba     VV", typeof(double), "Vychystávání -výroba     VV", true);
                schema.Add("Vychystávání výroba -manipulace    VM", typeof(double), "Vychystávání výroba -manipulace    VM", true);
                schema.Add("Vychystávání výroba-předkompletace    VP", typeof(double), "Vychystávání výroba-předkompletace    VP", true);
                schema.Add("Vychystávání          Vx", typeof(double), "Vychystávání          Vx", true);
                schema.Add("Přípravné činnosti    PP", typeof(double), "Přípravné činnosti    PP", true);
                schema.Add("Manipulační činnosti   PM", typeof(double), "Manipulační činnosti   PM", true);
                schema.Add("Výroba   Px", typeof(double), "Výroba   Px", true);
                schema.Add("Kompletace   K", typeof(double), "Kompletace   K", true);
                schema.Add("Routing  (s/ks)", typeof(double), "Routing  (s/ks)", true);
                schema.Add("Čas pro SAP", typeof(double), "Čas pro SAP", true);
                schema.Add("stejný čas jako image", typeof(double), "stejný čas jako image", true);
                schema.Add("counter no (do Z-tabulek)TOTO JE NYNÍ V SAPU", typeof(double), "counter no (do Z-tabulek)TOTO JE NYNÍ V SAPU", true);
                schema.Add("datum pro export a aktualizaci", typeof(string), "datum pro export a aktualizaci", true);
                schema.Add("aktuální Most formulář", typeof(string), "aktuální Most formulář", true);
                schema.Add("Poznámky ke komponentu", typeof(string), "Poznámky ke komponentu", true);
                schema.Add("Přirážka (%)", typeof(double), "Přirážka (%)", true);
                schema.Add("F36", typeof(string), "F36", true);
            }

            return schema;
        }

        public override void LoadDefaultValues()
        {
            SqlCommand command = Session.CreateCommand();

            this["status komponentu"] = DBNull.Value;

            this["číslo komponentu"] = DBNull.Value;

            this["Druh komponentu"] = DBNull.Value;

            this["interní komponetář"] = DBNull.Value;

            this["datum nafocení"] = DBNull.Value;

            this["Hlavní komponent"] = DBNull.Value;

            this["IFU"] = DBNull.Value;

            this["Oprava komponentu"] = DBNull.Value;

            this["Detail opravy komponentu"] = DBNull.Value;

            this["způsob vyskladnění"] = DBNull.Value;

            this["překontrolovat balení"] = DBNull.Value;

            this["Je potřeba čas revidovat? "] = DBNull.Value;

            this["Revize MOST"] = DBNull.Value;

            this["SAP"] = DBNull.Value;

            this["CW"] = DBNull.Value;

            this["LF"] = DBNull.Value;

            this["Starý formulář"] = DBNull.Value;

            this["IMAGE"] = DBNull.Value;

            this["Vychystávání -sklad        VS"] = DBNull.Value;

            this["Vychystávání -výroba     VV"] = DBNull.Value;

            this["Vychystávání výroba -manipulace    VM"] = DBNull.Value;

            this["Vychystávání výroba-předkompletace    VP"] = DBNull.Value;

            this["Vychystávání          Vx"] = DBNull.Value;

            this["Přípravné činnosti    PP"] = DBNull.Value;

            this["Manipulační činnosti   PM"] = DBNull.Value;

            this["Výroba   Px"] = DBNull.Value;

            this["Kompletace   K"] = DBNull.Value;

            this["Routing  (s/ks)"] = DBNull.Value;

            this["Čas pro SAP"] = DBNull.Value;

            this["stejný čas jako image"] = DBNull.Value;

            this["counter no (do Z-tabulek)TOTO JE NYNÍ V SAPU"] = DBNull.Value;

            this["datum pro export a aktualizaci"] = DBNull.Value;

            this["aktuální Most formulář"] = DBNull.Value;

            this["Poznámky ke komponentu"] = DBNull.Value;

            this["Přirážka (%)"] = DBNull.Value;

            this["F36"] = DBNull.Value;
        }

        public static ImportTimes Load()
        {
            ImportTimes result = new ImportTimes();
            result.LoadRecord();
            return result;
        }

        public static ImportTimes CachedLoad()
        {
            DbCache.TableKey key = new DbCache.TableKey("ImportTimes");
            DbCache.CacheRecord record;
            key.Set();
            if (DbCache.Contains(key))
            {
                record = DbCache.GetRecord(key);
                if (!record.IsValid())
                {
                    record.Value = Load();
                    record.LastUpdate = DateTime.Now;
                    record.Valid = true;
                }
            }
            else
            {
                record = new DbCache.CacheRecord();
                record.Value = Load();
                record.LastUpdate = DateTime.Now;
                record.Valid = true;
                DbCache.SetRecord(key, record);
            }
            return (ImportTimes)record.Value;
        }

        public static ImportTimes Create()
        {
            ImportTimes result = new ImportTimes();
            result.LoadDefaultValues();
            return result;
        }

        public static DbTable<ImportTimes> LoadAll()
        {
            DbTable<ImportTimes> table = new DbTable<ImportTimes>();
            ImportTimes prototype = new ImportTimes();
            prototype.LoadTable(table);
            return table;
        }

        public static DbTable<ImportTimes> LoadBy(string whereCondition, params object[] parameterValues)
        {
            DbTable<ImportTimes> table = new DbTable<ImportTimes>();
            ImportTimes prototype = new ImportTimes();
            prototype.LoadTable(table, whereCondition, parameterValues);
            return table;
        }
    }

    public class TMaterialComposition: DbObject
    {
        private static DbSchema schema = null;

        public int ComponentID
        {
            get { return DbConverter.ToInt(this["ComponentID"]); }
            set { this["ComponentID"] = DbConverter.FromInt(value); }
        }

        public int CompositionID
        {
            get { return DbConverter.ToInt(this["CompositionID"]); }
            set { this["CompositionID"] = DbConverter.FromInt(value); }
        }

        public DbNullable<string> Note
        {
            get { return DbConverter.ToStringNull(this["Note"]); }
            set { this["Note"] = DbConverter.FromStringNull(value); }
        }

        protected override DbSchema GetSchema()
        {
            if (schema == null)
            {
                schema = new DbSchema("TMaterialComposition");
                schema.Add("ComponentID", typeof(int), "ComponentID", false, true, false);
                schema.Add("CompositionID", typeof(int), "CompositionID", false, true, false);
                schema.Add("Note", typeof(string), "Note", true);
            }

            return schema;
        }

        public override void LoadDefaultValues()
        {
            SqlCommand command = Session.CreateCommand();

            this["ComponentID"] = DbConverter.DefaultInt();

            this["CompositionID"] = DbConverter.DefaultInt();

            this["Note"] = DBNull.Value;
        }

        public static TMaterialComposition Load(int componentID, int compositionID)
        {
            TMaterialComposition result = new TMaterialComposition();
            result.LoadRecord(componentID, compositionID);
            return result;
        }

        public static TMaterialComposition CachedLoad(int componentID, int compositionID)
        {
            DbCache.TableKey key = new DbCache.TableKey("TMaterialComposition");
            DbCache.CacheRecord record;
            key.Set(componentID, compositionID);
            if (DbCache.Contains(key))
            {
                record = DbCache.GetRecord(key);
                if (!record.IsValid())
                {
                    record.Value = Load(componentID, compositionID);
                    record.LastUpdate = DateTime.Now;
                    record.Valid = true;
                }
            }
            else
            {
                record = new DbCache.CacheRecord();
                record.Value = Load(componentID, compositionID);
                record.LastUpdate = DateTime.Now;
                record.Valid = true;
                DbCache.SetRecord(key, record);
            }
            return (TMaterialComposition)record.Value;
        }

        public static TMaterialComposition Create()
        {
            TMaterialComposition result = new TMaterialComposition();
            result.LoadDefaultValues();
            return result;
        }

        public static DbTable<TMaterialComposition> LoadAll()
        {
            DbTable<TMaterialComposition> table = new DbTable<TMaterialComposition>();
            TMaterialComposition prototype = new TMaterialComposition();
            prototype.LoadTable(table);
            return table;
        }

        public static DbTable<TMaterialComposition> LoadByComponentID(int componentID)
        {
            DbTable<TMaterialComposition> table = new DbTable<TMaterialComposition>();
            TMaterialComposition prototype = new TMaterialComposition();
            prototype.LoadTable(table, "[ComponentID]={0}", DbConverter.FromInt(componentID));
            return table;
        }

        public static DbTable<TMaterialComposition> LoadByCompositionID(int compositionID)
        {
            DbTable<TMaterialComposition> table = new DbTable<TMaterialComposition>();
            TMaterialComposition prototype = new TMaterialComposition();
            prototype.LoadTable(table, "[CompositionID]={0}", DbConverter.FromInt(compositionID));
            return table;
        }

        public static DbTable<TMaterialComposition> LoadBy(string whereCondition, params object[] parameterValues)
        {
            DbTable<TMaterialComposition> table = new DbTable<TMaterialComposition>();
            TMaterialComposition prototype = new TMaterialComposition();
            prototype.LoadTable(table, whereCondition, parameterValues);
            return table;
        }
    }

    public class TAttachmentSL: DbObject
    {
        private static DbSchema schema = null;

        public int SampleList
        {
            get { return DbConverter.ToInt(this["SampleList"]); }
            set { this["SampleList"] = DbConverter.FromInt(value); }
        }

        public int Attachment
        {
            get { return DbConverter.ToInt(this["Attachment"]); }
            set { this["Attachment"] = DbConverter.FromInt(value); }
        }

        protected override DbSchema GetSchema()
        {
            if (schema == null)
            {
                schema = new DbSchema("TAttachmentSL");
                schema.Add("SampleList", typeof(int), "SampleList", false, true, false);
                schema.Add("Attachment", typeof(int), "Attachment", false, true, false);
            }

            return schema;
        }

        public override void LoadDefaultValues()
        {
            SqlCommand command = Session.CreateCommand();

            this["SampleList"] = DbConverter.DefaultInt();

            this["Attachment"] = DbConverter.DefaultInt();
        }

        public static TAttachmentSL Load(int sampleList, int attachment)
        {
            TAttachmentSL result = new TAttachmentSL();
            result.LoadRecord(sampleList, attachment);
            return result;
        }

        public static TAttachmentSL CachedLoad(int sampleList, int attachment)
        {
            DbCache.TableKey key = new DbCache.TableKey("TAttachmentSL");
            DbCache.CacheRecord record;
            key.Set(sampleList, attachment);
            if (DbCache.Contains(key))
            {
                record = DbCache.GetRecord(key);
                if (!record.IsValid())
                {
                    record.Value = Load(sampleList, attachment);
                    record.LastUpdate = DateTime.Now;
                    record.Valid = true;
                }
            }
            else
            {
                record = new DbCache.CacheRecord();
                record.Value = Load(sampleList, attachment);
                record.LastUpdate = DateTime.Now;
                record.Valid = true;
                DbCache.SetRecord(key, record);
            }
            return (TAttachmentSL)record.Value;
        }

        public static TAttachmentSL Create()
        {
            TAttachmentSL result = new TAttachmentSL();
            result.LoadDefaultValues();
            return result;
        }

        public static DbTable<TAttachmentSL> LoadAll()
        {
            DbTable<TAttachmentSL> table = new DbTable<TAttachmentSL>();
            TAttachmentSL prototype = new TAttachmentSL();
            prototype.LoadTable(table);
            return table;
        }

        public static DbTable<TAttachmentSL> LoadBy(string whereCondition, params object[] parameterValues)
        {
            DbTable<TAttachmentSL> table = new DbTable<TAttachmentSL>();
            TAttachmentSL prototype = new TAttachmentSL();
            prototype.LoadTable(table, whereCondition, parameterValues);
            return table;
        }
    }

    public class sysdiagrams: DbObject
    {
        private static DbSchema schema = null;

        public string name
        {
            get { return DbConverter.ToString(this["name"]); }
            set { this["name"] = DbConverter.FromString(value); }
        }

        public int principal_id
        {
            get { return DbConverter.ToInt(this["principal_id"]); }
            set { this["principal_id"] = DbConverter.FromInt(value); }
        }

        public int diagram_id
        {
            get { return DbConverter.ToInt(this["diagram_id"]); }
            set { this["diagram_id"] = DbConverter.FromInt(value); }
        }

        public DbNullable<int> version
        {
            get { return DbConverter.ToIntNull(this["version"]); }
            set { this["version"] = DbConverter.FromIntNull(value); }
        }

        protected override DbSchema GetSchema()
        {
            if (schema == null)
            {
                schema = new DbSchema("sysdiagrams");
                schema.Add("name", typeof(string), "name", false);
                schema.Add("principal_id", typeof(int), "principal_id", false);
                schema.Add("diagram_id", typeof(int), "diagram_id", false, true, true);
                schema.Add("version", typeof(int), "version", true);
            }

            return schema;
        }

        public override void LoadDefaultValues()
        {
            SqlCommand command = Session.CreateCommand();

            this["name"] = DbConverter.DefaultString();

            this["principal_id"] = DbConverter.DefaultInt();

            this["diagram_id"] = DbConverter.DefaultInt();

            this["version"] = DBNull.Value;
        }

        public static sysdiagrams Load(int diagram_id)
        {
            sysdiagrams result = new sysdiagrams();
            result.LoadRecord(diagram_id);
            return result;
        }

        public static sysdiagrams CachedLoad(int diagram_id)
        {
            DbCache.TableKey key = new DbCache.TableKey("sysdiagrams");
            DbCache.CacheRecord record;
            key.Set(diagram_id);
            if (DbCache.Contains(key))
            {
                record = DbCache.GetRecord(key);
                if (!record.IsValid())
                {
                    record.Value = Load(diagram_id);
                    record.LastUpdate = DateTime.Now;
                    record.Valid = true;
                }
            }
            else
            {
                record = new DbCache.CacheRecord();
                record.Value = Load(diagram_id);
                record.LastUpdate = DateTime.Now;
                record.Valid = true;
                DbCache.SetRecord(key, record);
            }
            return (sysdiagrams)record.Value;
        }

        public static sysdiagrams Create()
        {
            sysdiagrams result = new sysdiagrams();
            result.LoadDefaultValues();
            return result;
        }

        public static DbTable<sysdiagrams> LoadAll()
        {
            DbTable<sysdiagrams> table = new DbTable<sysdiagrams>();
            sysdiagrams prototype = new sysdiagrams();
            prototype.LoadTable(table);
            return table;
        }

        public static DbTable<sysdiagrams> LoadBy(string whereCondition, params object[] parameterValues)
        {
            DbTable<sysdiagrams> table = new DbTable<sysdiagrams>();
            sysdiagrams prototype = new sysdiagrams();
            prototype.LoadTable(table, whereCondition, parameterValues);
            return table;
        }
    }

    public class TTestValues: DbObject
    {
        private static DbSchema schema = null;

        public string Value
        {
            get { return DbConverter.ToString(this["Value"]); }
            set { this["Value"] = DbConverter.FromString(value); }
        }

        protected override DbSchema GetSchema()
        {
            if (schema == null)
            {
                schema = new DbSchema("TTestValues");
                schema.Add("Value", typeof(string), "Value", false, true, false);
            }

            return schema;
        }

        public override void LoadDefaultValues()
        {
            SqlCommand command = Session.CreateCommand();

            this["Value"] = DbConverter.DefaultString();
        }

        public static TTestValues Load(string value)
        {
            TTestValues result = new TTestValues();
            result.LoadRecord(value);
            return result;
        }

        public static TTestValues CachedLoad(string value)
        {
            DbCache.TableKey key = new DbCache.TableKey("TTestValues");
            DbCache.CacheRecord record;
            key.Set(value);
            if (DbCache.Contains(key))
            {
                record = DbCache.GetRecord(key);
                if (!record.IsValid())
                {
                    record.Value = Load(value);
                    record.LastUpdate = DateTime.Now;
                    record.Valid = true;
                }
            }
            else
            {
                record = new DbCache.CacheRecord();
                record.Value = Load(value);
                record.LastUpdate = DateTime.Now;
                record.Valid = true;
                DbCache.SetRecord(key, record);
            }
            return (TTestValues)record.Value;
        }

        public static TTestValues Create()
        {
            TTestValues result = new TTestValues();
            result.LoadDefaultValues();
            return result;
        }

        public static DbTable<TTestValues> LoadAll()
        {
            DbTable<TTestValues> table = new DbTable<TTestValues>();
            TTestValues prototype = new TTestValues();
            prototype.LoadTable(table);
            return table;
        }

        public static DbTable<TTestValues> LoadBy(string whereCondition, params object[] parameterValues)
        {
            DbTable<TTestValues> table = new DbTable<TTestValues>();
            TTestValues prototype = new TTestValues();
            prototype.LoadTable(table, whereCondition, parameterValues);
            return table;
        }
    }

    public class TYesNo: DbObject
    {
        private static DbSchema schema = null;

        public string Value
        {
            get { return DbConverter.ToString(this["Value"]); }
            set { this["Value"] = DbConverter.FromString(value); }
        }

        protected override DbSchema GetSchema()
        {
            if (schema == null)
            {
                schema = new DbSchema("TYesNo");
                schema.Add("Value", typeof(string), "Value", false, true, false);
            }

            return schema;
        }

        public override void LoadDefaultValues()
        {
            SqlCommand command = Session.CreateCommand();

            this["Value"] = DbConverter.DefaultString();
        }

        public static TYesNo Load(string value)
        {
            TYesNo result = new TYesNo();
            result.LoadRecord(value);
            return result;
        }

        public static TYesNo CachedLoad(string value)
        {
            DbCache.TableKey key = new DbCache.TableKey("TYesNo");
            DbCache.CacheRecord record;
            key.Set(value);
            if (DbCache.Contains(key))
            {
                record = DbCache.GetRecord(key);
                if (!record.IsValid())
                {
                    record.Value = Load(value);
                    record.LastUpdate = DateTime.Now;
                    record.Valid = true;
                }
            }
            else
            {
                record = new DbCache.CacheRecord();
                record.Value = Load(value);
                record.LastUpdate = DateTime.Now;
                record.Valid = true;
                DbCache.SetRecord(key, record);
            }
            return (TYesNo)record.Value;
        }

        public static TYesNo Create()
        {
            TYesNo result = new TYesNo();
            result.LoadDefaultValues();
            return result;
        }

        public static DbTable<TYesNo> LoadAll()
        {
            DbTable<TYesNo> table = new DbTable<TYesNo>();
            TYesNo prototype = new TYesNo();
            prototype.LoadTable(table);
            return table;
        }

        public static DbTable<TYesNo> LoadBy(string whereCondition, params object[] parameterValues)
        {
            DbTable<TYesNo> table = new DbTable<TYesNo>();
            TYesNo prototype = new TYesNo();
            prototype.LoadTable(table, whereCondition, parameterValues);
            return table;
        }
    }

    public class TCEMark: DbObject
    {
        private static DbSchema schema = null;

        public string CEMark
        {
            get { return DbConverter.ToString(this["CEMark"]); }
            set { this["CEMark"] = DbConverter.FromString(value); }
        }

        protected override DbSchema GetSchema()
        {
            if (schema == null)
            {
                schema = new DbSchema("TCEMark");
                schema.Add("CEMark", typeof(string), "CEMark", false, true, false);
            }

            return schema;
        }

        public override void LoadDefaultValues()
        {
            SqlCommand command = Session.CreateCommand();

            this["CEMark"] = DbConverter.DefaultString();
        }

        public static TCEMark Load(string cEMark)
        {
            TCEMark result = new TCEMark();
            result.LoadRecord(cEMark);
            return result;
        }

        public static TCEMark CachedLoad(string cEMark)
        {
            DbCache.TableKey key = new DbCache.TableKey("TCEMark");
            DbCache.CacheRecord record;
            key.Set(cEMark);
            if (DbCache.Contains(key))
            {
                record = DbCache.GetRecord(key);
                if (!record.IsValid())
                {
                    record.Value = Load(cEMark);
                    record.LastUpdate = DateTime.Now;
                    record.Valid = true;
                }
            }
            else
            {
                record = new DbCache.CacheRecord();
                record.Value = Load(cEMark);
                record.LastUpdate = DateTime.Now;
                record.Valid = true;
                DbCache.SetRecord(key, record);
            }
            return (TCEMark)record.Value;
        }

        public static TCEMark Create()
        {
            TCEMark result = new TCEMark();
            result.LoadDefaultValues();
            return result;
        }

        public static DbTable<TCEMark> LoadAll()
        {
            DbTable<TCEMark> table = new DbTable<TCEMark>();
            TCEMark prototype = new TCEMark();
            prototype.LoadTable(table);
            return table;
        }

        public static DbTable<TCEMark> LoadBy(string whereCondition, params object[] parameterValues)
        {
            DbTable<TCEMark> table = new DbTable<TCEMark>();
            TCEMark prototype = new TCEMark();
            prototype.LoadTable(table, whereCondition, parameterValues);
            return table;
        }
    }

    public class TClass: DbObject
    {
        private static DbSchema schema = null;

        public string Class
        {
            get { return DbConverter.ToString(this["Class"]); }
            set { this["Class"] = DbConverter.FromString(value); }
        }

        protected override DbSchema GetSchema()
        {
            if (schema == null)
            {
                schema = new DbSchema("TClass");
                schema.Add("Class", typeof(string), "Class", false, true, false);
            }

            return schema;
        }

        public override void LoadDefaultValues()
        {
            SqlCommand command = Session.CreateCommand();

            this["Class"] = DbConverter.DefaultString();
        }

        public static TClass Load(string class_)
        {
            TClass result = new TClass();
            result.LoadRecord(class_);
            return result;
        }

        // TODO edit class to class_
        public static TClass CachedLoad(string class_)
        {
            DbCache.TableKey key = new DbCache.TableKey("TClass");
            DbCache.CacheRecord record;
            key.Set(class_);
            if (DbCache.Contains(key))
            {
                record = DbCache.GetRecord(key);
                if (!record.IsValid())
                {
                    record.Value = Load(class_);
                    record.LastUpdate = DateTime.Now;
                    record.Valid = true;
                }
            }
            else
            {
                record = new DbCache.CacheRecord();
                record.Value = Load(class_);
                record.LastUpdate = DateTime.Now;
                record.Valid = true;
                DbCache.SetRecord(key, record);
            }
            return (TClass)record.Value;
        }

        public static TClass Create()
        {
            TClass result = new TClass();
            result.LoadDefaultValues();
            return result;
        }

        public static DbTable<TClass> LoadAll()
        {
            DbTable<TClass> table = new DbTable<TClass>();
            TClass prototype = new TClass();
            prototype.LoadTable(table);
            return table;
        }

        public static DbTable<TClass> LoadBy(string whereCondition, params object[] parameterValues)
        {
            DbTable<TClass> table = new DbTable<TClass>();
            TClass prototype = new TClass();
            prototype.LoadTable(table, whereCondition, parameterValues);
            return table;
        }
    }

    public class _ImagesImport: DbObject
    {
        private static DbSchema schema = null;

        public DbNullable<string> Komponent
        {
            get { return DbConverter.ToStringNull(this["Komponent"]); }
            set { this["Komponent"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> Název_fotky
        {
            get { return DbConverter.ToStringNull(this["Název fotky"]); }
            set { this["Název fotky"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> číslo_fotky
        {
            get { return DbConverter.ToStringNull(this["číslo fotky"]); }
            set { this["číslo fotky"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> F4
        {
            get { return DbConverter.ToStringNull(this["F4"]); }
            set { this["F4"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> F5
        {
            get { return DbConverter.ToStringNull(this["F5"]); }
            set { this["F5"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<double> F6
        {
            get { return DbConverter.ToDoubleNull(this["F6"]); }
            set { this["F6"] = DbConverter.FromDoubleNull(value); }
        }

        protected override DbSchema GetSchema()
        {
            if (schema == null)
            {
                schema = new DbSchema("_ImagesImport");
                schema.Add("Komponent", typeof(string), "Komponent", true);
                schema.Add("Název fotky", typeof(string), "Název fotky", true);
                schema.Add("číslo fotky", typeof(string), "číslo fotky", true);
                schema.Add("F4", typeof(string), "F4", true);
                schema.Add("F5", typeof(string), "F5", true);
                schema.Add("F6", typeof(double), "F6", true);
            }

            return schema;
        }

        public override void LoadDefaultValues()
        {
            SqlCommand command = Session.CreateCommand();

            this["Komponent"] = DBNull.Value;

            this["Název fotky"] = DBNull.Value;

            this["číslo fotky"] = DBNull.Value;

            this["F4"] = DBNull.Value;

            this["F5"] = DBNull.Value;

            this["F6"] = DBNull.Value;
        }

        public static _ImagesImport Load()
        {
            _ImagesImport result = new _ImagesImport();
            result.LoadRecord();
            return result;
        }

        public static _ImagesImport CachedLoad()
        {
            DbCache.TableKey key = new DbCache.TableKey("_ImagesImport");
            DbCache.CacheRecord record;
            key.Set();
            if (DbCache.Contains(key))
            {
                record = DbCache.GetRecord(key);
                if (!record.IsValid())
                {
                    record.Value = Load();
                    record.LastUpdate = DateTime.Now;
                    record.Valid = true;
                }
            }
            else
            {
                record = new DbCache.CacheRecord();
                record.Value = Load();
                record.LastUpdate = DateTime.Now;
                record.Valid = true;
                DbCache.SetRecord(key, record);
            }
            return (_ImagesImport)record.Value;
        }

        public static _ImagesImport Create()
        {
            _ImagesImport result = new _ImagesImport();
            result.LoadDefaultValues();
            return result;
        }

        public static DbTable<_ImagesImport> LoadAll()
        {
            DbTable<_ImagesImport> table = new DbTable<_ImagesImport>();
            _ImagesImport prototype = new _ImagesImport();
            prototype.LoadTable(table);
            return table;
        }

        public static DbTable<_ImagesImport> LoadBy(string whereCondition, params object[] parameterValues)
        {
            DbTable<_ImagesImport> table = new DbTable<_ImagesImport>();
            _ImagesImport prototype = new _ImagesImport();
            prototype.LoadTable(table, whereCondition, parameterValues);
            return table;
        }
    }

    public class TCompanies: DbObject
    {
        private static DbSchema schema = null;

        public int CompanyID
        {
            get { return DbConverter.ToInt(this["CompanyID"]); }
            set { this["CompanyID"] = DbConverter.FromInt(value); }
        }

        public string Company
        {
            get { return DbConverter.ToString(this["Company"]); }
            set { this["Company"] = DbConverter.FromString(value); }
        }

        public bool Supplier
        {
            get { return DbConverter.ToBool(this["Supplier"]); }
            set { this["Supplier"] = DbConverter.FromBool(value); }
        }

        public bool Manufacturer
        {
            get { return DbConverter.ToBool(this["Manufacturer"]); }
            set { this["Manufacturer"] = DbConverter.FromBool(value); }
        }

        protected override DbSchema GetSchema()
        {
            if (schema == null)
            {
                schema = new DbSchema("TCompanies");
                schema.Add("CompanyID", typeof(int), "CompanyID", false, true, true);
                schema.Add("Company", typeof(string), "Company", false);
                schema.Add("Supplier", typeof(bool), "Supplier", false);
                schema.Add("Manufacturer", typeof(bool), "Manufacturer", false);
            }

            return schema;
        }

        public override void LoadDefaultValues()
        {
            SqlCommand command = Session.CreateCommand();

            this["CompanyID"] = DbConverter.DefaultInt();

            this["Company"] = DbConverter.DefaultString();

            command.CommandText = "SELECT (0)";
            this["Supplier"] = command.ExecuteScalar();

            command.CommandText = "SELECT (0)";
            this["Manufacturer"] = command.ExecuteScalar();
        }

        public static TCompanies Load(int companyID)
        {
            TCompanies result = new TCompanies();
            result.LoadRecord(companyID);
            return result;
        }

        public static TCompanies CachedLoad(int companyID)
        {
            DbCache.TableKey key = new DbCache.TableKey("TCompanies");
            DbCache.CacheRecord record;
            key.Set(companyID);
            if (DbCache.Contains(key))
            {
                record = DbCache.GetRecord(key);
                if (!record.IsValid())
                {
                    record.Value = Load(companyID);
                    record.LastUpdate = DateTime.Now;
                    record.Valid = true;
                }
            }
            else
            {
                record = new DbCache.CacheRecord();
                record.Value = Load(companyID);
                record.LastUpdate = DateTime.Now;
                record.Valid = true;
                DbCache.SetRecord(key, record);
            }
            return (TCompanies)record.Value;
        }

        public static TCompanies Create()
        {
            TCompanies result = new TCompanies();
            result.LoadDefaultValues();
            return result;
        }

        public static DbTable<TCompanies> LoadAll()
        {
            DbTable<TCompanies> table = new DbTable<TCompanies>();
            TCompanies prototype = new TCompanies();
            prototype.LoadTable(table);
            return table;
        }

        public static DbTable<TCompanies> LoadBy(string whereCondition, params object[] parameterValues)
        {
            DbTable<TCompanies> table = new DbTable<TCompanies>();
            TCompanies prototype = new TCompanies();
            prototype.LoadTable(table, whereCondition, parameterValues);
            return table;
        }
    }

    public class _ImagesImport2: DbObject
    {
        private static DbSchema schema = null;

        public DbNullable<string> Komponent
        {
            get { return DbConverter.ToStringNull(this["Komponent"]); }
            set { this["Komponent"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> Název_fotky
        {
            get { return DbConverter.ToStringNull(this["Název fotky"]); }
            set { this["Název fotky"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> číslo_fotky
        {
            get { return DbConverter.ToStringNull(this["číslo fotky"]); }
            set { this["číslo fotky"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> CisloFotkyText
        {
            get { return DbConverter.ToStringNull(this["CisloFotkyText"]); }
            set { this["CisloFotkyText"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> F5
        {
            get { return DbConverter.ToStringNull(this["F5"]); }
            set { this["F5"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<double> F6
        {
            get { return DbConverter.ToDoubleNull(this["F6"]); }
            set { this["F6"] = DbConverter.FromDoubleNull(value); }
        }

        protected override DbSchema GetSchema()
        {
            if (schema == null)
            {
                schema = new DbSchema("_ImagesImport2");
                schema.Add("Komponent", typeof(string), "Komponent", true);
                schema.Add("Název fotky", typeof(string), "Název fotky", true);
                schema.Add("číslo fotky", typeof(string), "číslo fotky", true);
                schema.Add("CisloFotkyText", typeof(string), "CisloFotkyText", true);
                schema.Add("F5", typeof(string), "F5", true);
                schema.Add("F6", typeof(double), "F6", true);
            }

            return schema;
        }

        public override void LoadDefaultValues()
        {
            SqlCommand command = Session.CreateCommand();

            this["Komponent"] = DBNull.Value;

            this["Název fotky"] = DBNull.Value;

            this["číslo fotky"] = DBNull.Value;

            this["CisloFotkyText"] = DBNull.Value;

            this["F5"] = DBNull.Value;

            this["F6"] = DBNull.Value;
        }

        public static _ImagesImport2 Load()
        {
            _ImagesImport2 result = new _ImagesImport2();
            result.LoadRecord();
            return result;
        }

        public static _ImagesImport2 CachedLoad()
        {
            DbCache.TableKey key = new DbCache.TableKey("_ImagesImport2");
            DbCache.CacheRecord record;
            key.Set();
            if (DbCache.Contains(key))
            {
                record = DbCache.GetRecord(key);
                if (!record.IsValid())
                {
                    record.Value = Load();
                    record.LastUpdate = DateTime.Now;
                    record.Valid = true;
                }
            }
            else
            {
                record = new DbCache.CacheRecord();
                record.Value = Load();
                record.LastUpdate = DateTime.Now;
                record.Valid = true;
                DbCache.SetRecord(key, record);
            }
            return (_ImagesImport2)record.Value;
        }

        public static _ImagesImport2 Create()
        {
            _ImagesImport2 result = new _ImagesImport2();
            result.LoadDefaultValues();
            return result;
        }

        public static DbTable<_ImagesImport2> LoadAll()
        {
            DbTable<_ImagesImport2> table = new DbTable<_ImagesImport2>();
            _ImagesImport2 prototype = new _ImagesImport2();
            prototype.LoadTable(table);
            return table;
        }

        public static DbTable<_ImagesImport2> LoadBy(string whereCondition, params object[] parameterValues)
        {
            DbTable<_ImagesImport2> table = new DbTable<_ImagesImport2>();
            _ImagesImport2 prototype = new _ImagesImport2();
            prototype.LoadTable(table, whereCondition, parameterValues);
            return table;
        }
    }

    public class TPDMStatus: DbObject
    {
        private static DbSchema schema = null;

        public int PDMStatusID
        {
            get { return DbConverter.ToInt(this["PDMStatusID"]); }
            set { this["PDMStatusID"] = DbConverter.FromInt(value); }
        }

        public string PDMStatus
        {
            get { return DbConverter.ToString(this["PDMStatus"]); }
            set { this["PDMStatus"] = DbConverter.FromString(value); }
        }

        protected override DbSchema GetSchema()
        {
            if (schema == null)
            {
                schema = new DbSchema("TPDMStatus");
                schema.Add("PDMStatusID", typeof(int), "PDMStatusID", false, true, true);
                schema.Add("PDMStatus", typeof(string), "PDMStatus", false);
            }

            return schema;
        }

        public override void LoadDefaultValues()
        {
            SqlCommand command = Session.CreateCommand();

            this["PDMStatusID"] = DbConverter.DefaultInt();

            this["PDMStatus"] = DbConverter.DefaultString();
        }

        public static TPDMStatus Load(int pDMStatusID)
        {
            TPDMStatus result = new TPDMStatus();
            result.LoadRecord(pDMStatusID);
            return result;
        }

        public static TPDMStatus CachedLoad(int pDMStatusID)
        {
            DbCache.TableKey key = new DbCache.TableKey("TPDMStatus");
            DbCache.CacheRecord record;
            key.Set(pDMStatusID);
            if (DbCache.Contains(key))
            {
                record = DbCache.GetRecord(key);
                if (!record.IsValid())
                {
                    record.Value = Load(pDMStatusID);
                    record.LastUpdate = DateTime.Now;
                    record.Valid = true;
                }
            }
            else
            {
                record = new DbCache.CacheRecord();
                record.Value = Load(pDMStatusID);
                record.LastUpdate = DateTime.Now;
                record.Valid = true;
                DbCache.SetRecord(key, record);
            }
            return (TPDMStatus)record.Value;
        }

        public static TPDMStatus Create()
        {
            TPDMStatus result = new TPDMStatus();
            result.LoadDefaultValues();
            return result;
        }

        public static DbTable<TPDMStatus> LoadAll()
        {
            DbTable<TPDMStatus> table = new DbTable<TPDMStatus>();
            TPDMStatus prototype = new TPDMStatus();
            prototype.LoadTable(table);
            return table;
        }

        public static DbTable<TPDMStatus> LoadBy(string whereCondition, params object[] parameterValues)
        {
            DbTable<TPDMStatus> table = new DbTable<TPDMStatus>();
            TPDMStatus prototype = new TPDMStatus();
            prototype.LoadTable(table, whereCondition, parameterValues);
            return table;
        }
    }

    public class _OpravyImport: DbObject
    {
        private static DbSchema schema = null;

        public DbNullable<string> Oprava_komponentu
        {
            get { return DbConverter.ToStringNull(this["Oprava komponentu"]); }
            set { this["Oprava komponentu"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> Detail_opravy_komponentu
        {
            get { return DbConverter.ToStringNull(this["Detail opravy komponentu"]); }
            set { this["Detail opravy komponentu"] = DbConverter.FromStringNull(value); }
        }

        protected override DbSchema GetSchema()
        {
            if (schema == null)
            {
                schema = new DbSchema("_OpravyImport");
                schema.Add("Oprava komponentu", typeof(string), "Oprava komponentu", true);
                schema.Add("Detail opravy komponentu", typeof(string), "Detail opravy komponentu", true);
            }

            return schema;
        }

        public override void LoadDefaultValues()
        {
            SqlCommand command = Session.CreateCommand();

            this["Oprava komponentu"] = DBNull.Value;

            this["Detail opravy komponentu"] = DBNull.Value;
        }

        public static _OpravyImport Load()
        {
            _OpravyImport result = new _OpravyImport();
            result.LoadRecord();
            return result;
        }

        public static _OpravyImport CachedLoad()
        {
            DbCache.TableKey key = new DbCache.TableKey("_OpravyImport");
            DbCache.CacheRecord record;
            key.Set();
            if (DbCache.Contains(key))
            {
                record = DbCache.GetRecord(key);
                if (!record.IsValid())
                {
                    record.Value = Load();
                    record.LastUpdate = DateTime.Now;
                    record.Valid = true;
                }
            }
            else
            {
                record = new DbCache.CacheRecord();
                record.Value = Load();
                record.LastUpdate = DateTime.Now;
                record.Valid = true;
                DbCache.SetRecord(key, record);
            }
            return (_OpravyImport)record.Value;
        }

        public static _OpravyImport Create()
        {
            _OpravyImport result = new _OpravyImport();
            result.LoadDefaultValues();
            return result;
        }

        public static DbTable<_OpravyImport> LoadAll()
        {
            DbTable<_OpravyImport> table = new DbTable<_OpravyImport>();
            _OpravyImport prototype = new _OpravyImport();
            prototype.LoadTable(table);
            return table;
        }

        public static DbTable<_OpravyImport> LoadBy(string whereCondition, params object[] parameterValues)
        {
            DbTable<_OpravyImport> table = new DbTable<_OpravyImport>();
            _OpravyImport prototype = new _OpravyImport();
            prototype.LoadTable(table, whereCondition, parameterValues);
            return table;
        }
    }

    public class TPrikazVyskladDetail: DbObject
    {
        private static DbSchema schema = null;

        public int IDPrikazVYskladDetail
        {
            get { return DbConverter.ToInt(this["IDPrikazVYskladDetail"]); }
            set { this["IDPrikazVYskladDetail"] = DbConverter.FromInt(value); }
        }

        public int PrikazVyskladID
        {
            get { return DbConverter.ToInt(this["PrikazVyskladID"]); }
            set { this["PrikazVyskladID"] = DbConverter.FromInt(value); }
        }

        public DbNullable<int> ComponentID
        {
            get { return DbConverter.ToIntNull(this["ComponentID"]); }
            set { this["ComponentID"] = DbConverter.FromIntNull(value); }
        }

        public DbNullable<string> Description
        {
            get { return DbConverter.ToStringNull(this["Description"]); }
            set { this["Description"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<int> Qty
        {
            get { return DbConverter.ToIntNull(this["Qty"]); }
            set { this["Qty"] = DbConverter.FromIntNull(value); }
        }

        protected override DbSchema GetSchema()
        {
            if (schema == null)
            {
                schema = new DbSchema("TPrikazVyskladDetail");
                schema.Add("IDPrikazVYskladDetail", typeof(int), "IDPrikazVYskladDetail", false, true, true);
                schema.Add("PrikazVyskladID", typeof(int), "PrikazVyskladID", false, true, false);
                schema.Add("ComponentID", typeof(int), "ComponentID", true);
                schema.Add("Description", typeof(string), "Description", true);
                schema.Add("Qty", typeof(int), "Qty", true);
            }

            return schema;
        }

        public override void LoadDefaultValues()
        {
            SqlCommand command = Session.CreateCommand();

            this["IDPrikazVYskladDetail"] = DbConverter.DefaultInt();

            this["PrikazVyskladID"] = DbConverter.DefaultInt();

            this["ComponentID"] = DBNull.Value;

            this["Description"] = DBNull.Value;

            command.CommandText = "SELECT ((0))";
            this["Qty"] = command.ExecuteScalar();
        }

        public static TPrikazVyskladDetail Load(int iDPrikazVYskladDetail, int prikazVyskladID)
        {
            TPrikazVyskladDetail result = new TPrikazVyskladDetail();
            result.LoadRecord(iDPrikazVYskladDetail, prikazVyskladID);
            return result;
        }

        public static TPrikazVyskladDetail CachedLoad(int iDPrikazVYskladDetail, int prikazVyskladID)
        {
            DbCache.TableKey key = new DbCache.TableKey("TPrikazVyskladDetail");
            DbCache.CacheRecord record;
            key.Set(iDPrikazVYskladDetail, prikazVyskladID);
            if (DbCache.Contains(key))
            {
                record = DbCache.GetRecord(key);
                if (!record.IsValid())
                {
                    record.Value = Load(iDPrikazVYskladDetail, prikazVyskladID);
                    record.LastUpdate = DateTime.Now;
                    record.Valid = true;
                }
            }
            else
            {
                record = new DbCache.CacheRecord();
                record.Value = Load(iDPrikazVYskladDetail, prikazVyskladID);
                record.LastUpdate = DateTime.Now;
                record.Valid = true;
                DbCache.SetRecord(key, record);
            }
            return (TPrikazVyskladDetail)record.Value;
        }

        public static TPrikazVyskladDetail Create()
        {
            TPrikazVyskladDetail result = new TPrikazVyskladDetail();
            result.LoadDefaultValues();
            return result;
        }

        public static DbTable<TPrikazVyskladDetail> LoadAll()
        {
            DbTable<TPrikazVyskladDetail> table = new DbTable<TPrikazVyskladDetail>();
            TPrikazVyskladDetail prototype = new TPrikazVyskladDetail();
            prototype.LoadTable(table);
            return table;
        }

        public static DbTable<TPrikazVyskladDetail> LoadByPrikazVyskladID(int prikazVyskladID)
        {
            DbTable<TPrikazVyskladDetail> table = new DbTable<TPrikazVyskladDetail>();
            TPrikazVyskladDetail prototype = new TPrikazVyskladDetail();
            prototype.LoadTable(table, "[PrikazVyskladID]={0}", DbConverter.FromInt(prikazVyskladID));
            return table;
        }

        public static DbTable<TPrikazVyskladDetail> LoadByComponentID(DbNullable<int> componentID)
        {
            DbTable<TPrikazVyskladDetail> table = new DbTable<TPrikazVyskladDetail>();
            TPrikazVyskladDetail prototype = new TPrikazVyskladDetail();
            prototype.LoadTable(table, "[ComponentID]={0}", DbConverter.FromIntNull(componentID));
            return table;
        }

        public static DbTable<TPrikazVyskladDetail> LoadBy(string whereCondition, params object[] parameterValues)
        {
            DbTable<TPrikazVyskladDetail> table = new DbTable<TPrikazVyskladDetail>();
            TPrikazVyskladDetail prototype = new TPrikazVyskladDetail();
            prototype.LoadTable(table, whereCondition, parameterValues);
            return table;
        }
    }

    public class _TimeRevisionImport: DbObject
    {
        private static DbSchema schema = null;

        public DbNullable<string> Komponent
        {
            get { return DbConverter.ToStringNull(this["Komponent"]); }
            set { this["Komponent"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<double> Revize
        {
            get { return DbConverter.ToDoubleNull(this["Revize"]); }
            set { this["Revize"] = DbConverter.FromDoubleNull(value); }
        }

        public DbNullable<string> Akt_revize
        {
            get { return DbConverter.ToStringNull(this["Akt_revize"]); }
            set { this["Akt_revize"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> Zpusob_vyskladneni
        {
            get { return DbConverter.ToStringNull(this["Zpusob_vyskladneni"]); }
            set { this["Zpusob_vyskladneni"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> Oprava
        {
            get { return DbConverter.ToStringNull(this["Oprava"]); }
            set { this["Oprava"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> Oprava_poznamka
        {
            get { return DbConverter.ToStringNull(this["Oprava_poznamka"]); }
            set { this["Oprava_poznamka"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> TypRevize
        {
            get { return DbConverter.ToStringNull(this["TypRevize"]); }
            set { this["TypRevize"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<double> TypRevizeCislo
        {
            get { return DbConverter.ToDoubleNull(this["TypRevizeCislo"]); }
            set { this["TypRevizeCislo"] = DbConverter.FromDoubleNull(value); }
        }

        public DbNullable<string> IFU
        {
            get { return DbConverter.ToStringNull(this["IFU"]); }
            set { this["IFU"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<double> IFU_CheckBox
        {
            get { return DbConverter.ToDoubleNull(this["IFU_CheckBox"]); }
            set { this["IFU_CheckBox"] = DbConverter.FromDoubleNull(value); }
        }

        public DbNullable<string> Prekontrolovat_baleni
        {
            get { return DbConverter.ToStringNull(this["Prekontrolovat_baleni"]); }
            set { this["Prekontrolovat_baleni"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> Revize_poznamka
        {
            get { return DbConverter.ToStringNull(this["Revize_poznamka"]); }
            set { this["Revize_poznamka"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> Revize_zkontrolovana
        {
            get { return DbConverter.ToStringNull(this["Revize_zkontrolovana"]); }
            set { this["Revize_zkontrolovana"] = DbConverter.FromStringNull(value); }
        }

        // TODO remove #
        public DbNullable<string> Hlavní_komp
        {
            get { return DbConverter.ToStringNull(this["Hlavní komp"]); }
            set { this["Hlavní komp"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> Fotka
        {
            get { return DbConverter.ToStringNull(this["Fotka"]); }
            set { this["Fotka"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> FotkaTxt
        {
            get { return DbConverter.ToStringNull(this["FotkaTxt"]); }
            set { this["FotkaTxt"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<double> VS
        {
            get { return DbConverter.ToDoubleNull(this["VS"]); }
            set { this["VS"] = DbConverter.FromDoubleNull(value); }
        }

        public DbNullable<double> VV
        {
            get { return DbConverter.ToDoubleNull(this["VV"]); }
            set { this["VV"] = DbConverter.FromDoubleNull(value); }
        }

        public DbNullable<double> VM
        {
            get { return DbConverter.ToDoubleNull(this["VM"]); }
            set { this["VM"] = DbConverter.FromDoubleNull(value); }
        }

        public DbNullable<double> VP
        {
            get { return DbConverter.ToDoubleNull(this["VP"]); }
            set { this["VP"] = DbConverter.FromDoubleNull(value); }
        }

        public DbNullable<double> Vx
        {
            get { return DbConverter.ToDoubleNull(this["Vx"]); }
            set { this["Vx"] = DbConverter.FromDoubleNull(value); }
        }

        public DbNullable<double> PP
        {
            get { return DbConverter.ToDoubleNull(this["PP"]); }
            set { this["PP"] = DbConverter.FromDoubleNull(value); }
        }

        public DbNullable<double> PM
        {
            get { return DbConverter.ToDoubleNull(this["PM"]); }
            set { this["PM"] = DbConverter.FromDoubleNull(value); }
        }

        public DbNullable<double> Px
        {
            get { return DbConverter.ToDoubleNull(this["Px"]); }
            set { this["Px"] = DbConverter.FromDoubleNull(value); }
        }

        public DbNullable<double> K
        {
            get { return DbConverter.ToDoubleNull(this["K"]); }
            set { this["K"] = DbConverter.FromDoubleNull(value); }
        }

        public DbNullable<double> Routing
        {
            get { return DbConverter.ToDoubleNull(this["Routing"]); }
            set { this["Routing"] = DbConverter.FromDoubleNull(value); }
        }

        public DbNullable<double> TimeSAP
        {
            get { return DbConverter.ToDoubleNull(this["TimeSAP"]); }
            set { this["TimeSAP"] = DbConverter.FromDoubleNull(value); }
        }

        public DbNullable<string> Zdroj_casu
        {
            get { return DbConverter.ToStringNull(this["Zdroj_casu"]); }
            set { this["Zdroj_casu"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> Exportovano
        {
            get { return DbConverter.ToStringNull(this["Exportovano"]); }
            set { this["Exportovano"] = DbConverter.FromStringNull(value); }
        }

        protected override DbSchema GetSchema()
        {
            if (schema == null)
            {
                schema = new DbSchema("_TimeRevisionImport");
                schema.Add("Komponent", typeof(string), "Komponent", true);
                schema.Add("Revize", typeof(double), "Revize", true);
                schema.Add("Akt_revize", typeof(string), "Akt_revize", true);
                schema.Add("Zpusob_vyskladneni", typeof(string), "Zpusob_vyskladneni", true);
                schema.Add("Oprava", typeof(string), "Oprava", true);
                schema.Add("Oprava_poznamka", typeof(string), "Oprava_poznamka", true);
                schema.Add("TypRevize", typeof(string), "TypRevize", true);
                schema.Add("TypRevizeCislo", typeof(double), "TypRevizeCislo", true);
                schema.Add("IFU", typeof(string), "IFU", true);
                schema.Add("IFU_CheckBox", typeof(double), "IFU_CheckBox", true);
                schema.Add("Prekontrolovat_baleni", typeof(string), "Prekontrolovat_baleni", true);
                schema.Add("Revize_poznamka", typeof(string), "Revize_poznamka", true);
                schema.Add("Revize_zkontrolovana", typeof(string), "Revize_zkontrolovana", true);
                schema.Add("Hlavní komp#", typeof(string), "Hlavní komp#", true);
                schema.Add("Fotka", typeof(string), "Fotka", true);
                schema.Add("FotkaTxt", typeof(string), "FotkaTxt", true);
                schema.Add("VS", typeof(double), "VS", true);
                schema.Add("VV", typeof(double), "VV", true);
                schema.Add("VM", typeof(double), "VM", true);
                schema.Add("VP", typeof(double), "VP", true);
                schema.Add("Vx", typeof(double), "Vx", true);
                schema.Add("PP", typeof(double), "PP", true);
                schema.Add("PM", typeof(double), "PM", true);
                schema.Add("Px", typeof(double), "Px", true);
                schema.Add("K", typeof(double), "K", true);
                schema.Add("Routing", typeof(double), "Routing", true);
                schema.Add("TimeSAP", typeof(double), "TimeSAP", true);
                schema.Add("Zdroj_casu", typeof(string), "Zdroj_casu", true);
                schema.Add("Exportovano", typeof(string), "Exportovano", true);
            }

            return schema;
        }

        public override void LoadDefaultValues()
        {
            SqlCommand command = Session.CreateCommand();

            this["Komponent"] = DBNull.Value;

            this["Revize"] = DBNull.Value;

            this["Akt_revize"] = DBNull.Value;

            this["Zpusob_vyskladneni"] = DBNull.Value;

            this["Oprava"] = DBNull.Value;

            this["Oprava_poznamka"] = DBNull.Value;

            this["TypRevize"] = DBNull.Value;

            this["TypRevizeCislo"] = DBNull.Value;

            this["IFU"] = DBNull.Value;

            this["IFU_CheckBox"] = DBNull.Value;

            this["Prekontrolovat_baleni"] = DBNull.Value;

            this["Revize_poznamka"] = DBNull.Value;

            this["Revize_zkontrolovana"] = DBNull.Value;

            this["Hlavní komp#"] = DBNull.Value;

            this["Fotka"] = DBNull.Value;

            this["FotkaTxt"] = DBNull.Value;

            this["VS"] = DBNull.Value;

            this["VV"] = DBNull.Value;

            this["VM"] = DBNull.Value;

            this["VP"] = DBNull.Value;

            this["Vx"] = DBNull.Value;

            this["PP"] = DBNull.Value;

            this["PM"] = DBNull.Value;

            this["Px"] = DBNull.Value;

            this["K"] = DBNull.Value;

            this["Routing"] = DBNull.Value;

            this["TimeSAP"] = DBNull.Value;

            this["Zdroj_casu"] = DBNull.Value;

            this["Exportovano"] = DBNull.Value;
        }

        public static _TimeRevisionImport Load()
        {
            _TimeRevisionImport result = new _TimeRevisionImport();
            result.LoadRecord();
            return result;
        }

        public static _TimeRevisionImport CachedLoad()
        {
            DbCache.TableKey key = new DbCache.TableKey("_TimeRevisionImport");
            DbCache.CacheRecord record;
            key.Set();
            if (DbCache.Contains(key))
            {
                record = DbCache.GetRecord(key);
                if (!record.IsValid())
                {
                    record.Value = Load();
                    record.LastUpdate = DateTime.Now;
                    record.Valid = true;
                }
            }
            else
            {
                record = new DbCache.CacheRecord();
                record.Value = Load();
                record.LastUpdate = DateTime.Now;
                record.Valid = true;
                DbCache.SetRecord(key, record);
            }
            return (_TimeRevisionImport)record.Value;
        }

        public static _TimeRevisionImport Create()
        {
            _TimeRevisionImport result = new _TimeRevisionImport();
            result.LoadDefaultValues();
            return result;
        }

        public static DbTable<_TimeRevisionImport> LoadAll()
        {
            DbTable<_TimeRevisionImport> table = new DbTable<_TimeRevisionImport>();
            _TimeRevisionImport prototype = new _TimeRevisionImport();
            prototype.LoadTable(table);
            return table;
        }

        public static DbTable<_TimeRevisionImport> LoadBy(string whereCondition, params object[] parameterValues)
        {
            DbTable<_TimeRevisionImport> table = new DbTable<_TimeRevisionImport>();
            _TimeRevisionImport prototype = new _TimeRevisionImport();
            prototype.LoadTable(table, whereCondition, parameterValues);
            return table;
        }
    }

    public class TNewDataXLS: DbObject
    {
        private static DbSchema schema = null;

        public DbNullable<string> MHC_Code
        {
            get { return DbConverter.ToStringNull(this["MHC Code"]); }
            set { this["MHC Code"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> Vendor_code
        {
            get { return DbConverter.ToStringNull(this["Vendor code"]); }
            set { this["Vendor code"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> Responsible
        {
            get { return DbConverter.ToStringNull(this["Responsible"]); }
            set { this["Responsible"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> Description
        {
            get { return DbConverter.ToStringNull(this["Description"]); }
            set { this["Description"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> Supplier
        {
            get { return DbConverter.ToStringNull(this["Supplier"]); }
            set { this["Supplier"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> Manufacturer
        {
            get { return DbConverter.ToStringNull(this["Manufacturer"]); }
            set { this["Manufacturer"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> Composition
        {
            get { return DbConverter.ToStringNull(this["Composition"]); }
            set { this["Composition"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<DateTime> Set_up_date
        {
            get { return DbConverter.ToDateTimeNull(this["Set up date"]); }
            set { this["Set up date"] = DbConverter.FromDateTimeNull(value); }
        }

        public DbNullable<DateTime> Approval_date
        {
            get { return DbConverter.ToDateTimeNull(this["Approval date"]); }
            set { this["Approval date"] = DbConverter.FromDateTimeNull(value); }
        }

        public DbNullable<string> Status
        {
            get { return DbConverter.ToStringNull(this["Status"]); }
            set { this["Status"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> Physical_check
        {
            get { return DbConverter.ToStringNull(this["Physical check"]); }
            set { this["Physical check"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> Issue
        {
            get { return DbConverter.ToStringNull(this["Issue"]); }
            set { this["Issue"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> MDD_Class
        {
            get { return DbConverter.ToStringNull(this["MDD Class"]); }
            set { this["MDD Class"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> CE_Mark
        {
            get { return DbConverter.ToStringNull(this["CE Mark"]); }
            set { this["CE Mark"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<DateTime> Expiry_issue_Date
        {
            get { return DbConverter.ToDateTimeNull(this["Expiry_issue_Date"]); }
            set { this["Expiry_issue_Date"] = DbConverter.FromDateTimeNull(value); }
        }

        public DbNullable<DateTime> Questionnaire_date
        {
            get { return DbConverter.ToDateTimeNull(this["Questionnaire date"]); }
            set { this["Questionnaire date"] = DbConverter.FromDateTimeNull(value); }
        }

        public DbNullable<string> Questionnaire_status
        {
            get { return DbConverter.ToStringNull(this["Questionnaire status"]); }
            set { this["Questionnaire status"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> References
        {
            get { return DbConverter.ToStringNull(this["References"]); }
            set { this["References"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> Residuals
        {
            get { return DbConverter.ToStringNull(this["Residuals"]); }
            set { this["Residuals"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> Intended_use
        {
            get { return DbConverter.ToStringNull(this["Intended use"]); }
            set { this["Intended use"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> PVC
        {
            get { return DbConverter.ToStringNull(this["PVC"]); }
            set { this["PVC"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> DEPH
        {
            get { return DbConverter.ToStringNull(this["DEPH"]); }
            set { this["DEPH"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> Latex_in_component
        {
            get { return DbConverter.ToStringNull(this["Latex in component"]); }
            set { this["Latex in component"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> Latex_in_packaging
        {
            get { return DbConverter.ToStringNull(this["Latex in packaging"]); }
            set { this["Latex in packaging"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> Pyrogen
        {
            get { return DbConverter.ToStringNull(this["Pyrogen"]); }
            set { this["Pyrogen"] = DbConverter.FromStringNull(value); }
        }

        // TODO remove #
        public DbNullable<string> max_sterilization_temperature
        {
            get { return DbConverter.ToStringNull(this["max sterilization temperature"]); }
            set { this["max sterilization temperature"] = DbConverter.FromStringNull(value); }
        }

        // TODO remove #
        public DbNullable<string> Max_vacuum
        {
            get { return DbConverter.ToStringNull(this["Max# vacuum"]); }
            set { this["Max# vacuum"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> Other_storage_condition
        {
            get { return DbConverter.ToStringNull(this["Other storage condition"]); }
            set { this["Other storage condition"] = DbConverter.FromStringNull(value); }
        }

        public bool Checked
        {
            get { return DbConverter.ToBool(this["Checked"]); }
            set { this["Checked"] = DbConverter.FromBool(value); }
        }

        public bool New
        {
            get { return DbConverter.ToBool(this["New"]); }
            set { this["New"] = DbConverter.FromBool(value); }
        }

        public int ID
        {
            get { return DbConverter.ToInt(this["ID"]); }
            set { this["ID"] = DbConverter.FromInt(value); }
        }

        protected override DbSchema GetSchema()
        {
            if (schema == null)
            {
                schema = new DbSchema("TNewDataXLS");
                schema.Add("MHC Code", typeof(string), "MHC Code", true);
                schema.Add("Vendor code", typeof(string), "Vendor code", true);
                schema.Add("Responsible", typeof(string), "Responsible", true);
                schema.Add("Description", typeof(string), "Description", true);
                schema.Add("Supplier", typeof(string), "Supplier", true);
                schema.Add("Manufacturer", typeof(string), "Manufacturer", true);
                schema.Add("Composition", typeof(string), "Composition", true);
                schema.Add("Set up date", typeof(DateTime), "Set up date", true);
                schema.Add("Approval date", typeof(DateTime), "Approval date", true);
                schema.Add("Status", typeof(string), "Status", true);
                schema.Add("Physical check", typeof(string), "Physical check", true);
                schema.Add("Issue", typeof(string), "Issue", true);
                schema.Add("MDD Class", typeof(string), "MDD Class", true);
                schema.Add("CE Mark", typeof(string), "CE Mark", true);
                schema.Add("Expiry/issue Date", typeof(DateTime), "Expiry/issue Date", true);
                schema.Add("Questionnaire date", typeof(DateTime), "Questionnaire date", true);
                schema.Add("Questionnaire status", typeof(string), "Questionnaire status", true);
                schema.Add("References", typeof(string), "References", true);
                schema.Add("Residuals", typeof(string), "Residuals", true);
                schema.Add("Intended use", typeof(string), "Intended use", true);
                schema.Add("PVC", typeof(string), "PVC", true);
                schema.Add("DEPH", typeof(string), "DEPH", true);
                schema.Add("Latex in component", typeof(string), "Latex in component", true);
                schema.Add("Latex in packaging", typeof(string), "Latex in packaging", true);
                schema.Add("Pyrogen", typeof(string), "Pyrogen", true);
                schema.Add("max# sterilization temperature", typeof(string), "max# sterilization temperature", true);
                schema.Add("Max# vacuum", typeof(string), "Max# vacuum", true);
                schema.Add("Other storage condition", typeof(string), "Other storage condition", true);
                schema.Add("Checked", typeof(bool), "Checked", false);
                schema.Add("New", typeof(bool), "New", false);
                schema.Add("ID", typeof(int), "ID", false, false, true);
            }

            return schema;
        }

        public override void LoadDefaultValues()
        {
            SqlCommand command = Session.CreateCommand();

            this["MHC Code"] = DBNull.Value;

            this["Vendor code"] = DBNull.Value;

            this["Responsible"] = DBNull.Value;

            this["Description"] = DBNull.Value;

            this["Supplier"] = DBNull.Value;

            this["Manufacturer"] = DBNull.Value;

            this["Composition"] = DBNull.Value;

            this["Set up date"] = DBNull.Value;

            this["Approval date"] = DBNull.Value;

            this["Status"] = DBNull.Value;

            this["Physical check"] = DBNull.Value;

            this["Issue"] = DBNull.Value;

            this["MDD Class"] = DBNull.Value;

            this["CE Mark"] = DBNull.Value;

            this["Expiry/issue Date"] = DBNull.Value;

            this["Questionnaire date"] = DBNull.Value;

            this["Questionnaire status"] = DBNull.Value;

            this["References"] = DBNull.Value;

            this["Residuals"] = DBNull.Value;

            this["Intended use"] = DBNull.Value;

            this["PVC"] = DBNull.Value;

            this["DEPH"] = DBNull.Value;

            this["Latex in component"] = DBNull.Value;

            this["Latex in packaging"] = DBNull.Value;

            this["Pyrogen"] = DBNull.Value;

            this["max# sterilization temperature"] = DBNull.Value;

            this["Max# vacuum"] = DBNull.Value;

            this["Other storage condition"] = DBNull.Value;

            this["Checked"] = DbConverter.DefaultBool();

            this["New"] = DbConverter.DefaultBool();

            this["ID"] = DbConverter.DefaultInt();
        }

        public static TNewDataXLS Load()
        {
            TNewDataXLS result = new TNewDataXLS();
            result.LoadRecord();
            return result;
        }

        public static TNewDataXLS CachedLoad()
        {
            DbCache.TableKey key = new DbCache.TableKey("TNewDataXLS");
            DbCache.CacheRecord record;
            key.Set();
            if (DbCache.Contains(key))
            {
                record = DbCache.GetRecord(key);
                if (!record.IsValid())
                {
                    record.Value = Load();
                    record.LastUpdate = DateTime.Now;
                    record.Valid = true;
                }
            }
            else
            {
                record = new DbCache.CacheRecord();
                record.Value = Load();
                record.LastUpdate = DateTime.Now;
                record.Valid = true;
                DbCache.SetRecord(key, record);
            }
            return (TNewDataXLS)record.Value;
        }

        public static TNewDataXLS Create()
        {
            TNewDataXLS result = new TNewDataXLS();
            result.LoadDefaultValues();
            return result;
        }

        public static DbTable<TNewDataXLS> LoadAll()
        {
            DbTable<TNewDataXLS> table = new DbTable<TNewDataXLS>();
            TNewDataXLS prototype = new TNewDataXLS();
            prototype.LoadTable(table);
            return table;
        }

        public static DbTable<TNewDataXLS> LoadBy(string whereCondition, params object[] parameterValues)
        {
            DbTable<TNewDataXLS> table = new DbTable<TNewDataXLS>();
            TNewDataXLS prototype = new TNewDataXLS();
            prototype.LoadTable(table, whereCondition, parameterValues);
            return table;
        }
    }

    public class TPickType: DbObject
    {
        private static DbSchema schema = null;

        public int PickTypeID
        {
            get { return DbConverter.ToInt(this["PickTypeID"]); }
            set { this["PickTypeID"] = DbConverter.FromInt(value); }
        }

        public string PickTypeName
        {
            get { return DbConverter.ToString(this["PickTypeName"]); }
            set { this["PickTypeName"] = DbConverter.FromString(value); }
        }

        protected override DbSchema GetSchema()
        {
            if (schema == null)
            {
                schema = new DbSchema("TPickType");
                schema.Add("PickTypeID", typeof(int), "PickTypeID", false, true, true);
                schema.Add("PickTypeName", typeof(string), "PickTypeName", false);
            }

            return schema;
        }

        public override void LoadDefaultValues()
        {
            SqlCommand command = Session.CreateCommand();

            this["PickTypeID"] = DbConverter.DefaultInt();

            this["PickTypeName"] = DbConverter.DefaultString();
        }

        public static TPickType Load(int pickTypeID)
        {
            TPickType result = new TPickType();
            result.LoadRecord(pickTypeID);
            return result;
        }

        public static TPickType CachedLoad(int pickTypeID)
        {
            DbCache.TableKey key = new DbCache.TableKey("TPickType");
            DbCache.CacheRecord record;
            key.Set(pickTypeID);
            if (DbCache.Contains(key))
            {
                record = DbCache.GetRecord(key);
                if (!record.IsValid())
                {
                    record.Value = Load(pickTypeID);
                    record.LastUpdate = DateTime.Now;
                    record.Valid = true;
                }
            }
            else
            {
                record = new DbCache.CacheRecord();
                record.Value = Load(pickTypeID);
                record.LastUpdate = DateTime.Now;
                record.Valid = true;
                DbCache.SetRecord(key, record);
            }
            return (TPickType)record.Value;
        }

        public static TPickType Create()
        {
            TPickType result = new TPickType();
            result.LoadDefaultValues();
            return result;
        }

        public static DbTable<TPickType> LoadAll()
        {
            DbTable<TPickType> table = new DbTable<TPickType>();
            TPickType prototype = new TPickType();
            prototype.LoadTable(table);
            return table;
        }

        public static DbTable<TPickType> LoadBy(string whereCondition, params object[] parameterValues)
        {
            DbTable<TPickType> table = new DbTable<TPickType>();
            TPickType prototype = new TPickType();
            prototype.LoadTable(table, whereCondition, parameterValues);
            return table;
        }
    }

    public class TQuestionnaireStatus: DbObject
    {
        private static DbSchema schema = null;

        public int QStatusID
        {
            get { return DbConverter.ToInt(this["QStatusID"]); }
            set { this["QStatusID"] = DbConverter.FromInt(value); }
        }

        public DbNullable<string> QStatusName
        {
            get { return DbConverter.ToStringNull(this["QStatusName"]); }
            set { this["QStatusName"] = DbConverter.FromStringNull(value); }
        }

        protected override DbSchema GetSchema()
        {
            if (schema == null)
            {
                schema = new DbSchema("TQuestionnaireStatus");
                schema.Add("QStatusID", typeof(int), "QStatusID", false, true, true);
                schema.Add("QStatusName", typeof(string), "QStatusName", true);
            }

            return schema;
        }

        public override void LoadDefaultValues()
        {
            SqlCommand command = Session.CreateCommand();

            this["QStatusID"] = DbConverter.DefaultInt();

            this["QStatusName"] = DBNull.Value;
        }

        public static TQuestionnaireStatus Load(int qStatusID)
        {
            TQuestionnaireStatus result = new TQuestionnaireStatus();
            result.LoadRecord(qStatusID);
            return result;
        }

        public static TQuestionnaireStatus CachedLoad(int qStatusID)
        {
            DbCache.TableKey key = new DbCache.TableKey("TQuestionnaireStatus");
            DbCache.CacheRecord record;
            key.Set(qStatusID);
            if (DbCache.Contains(key))
            {
                record = DbCache.GetRecord(key);
                if (!record.IsValid())
                {
                    record.Value = Load(qStatusID);
                    record.LastUpdate = DateTime.Now;
                    record.Valid = true;
                }
            }
            else
            {
                record = new DbCache.CacheRecord();
                record.Value = Load(qStatusID);
                record.LastUpdate = DateTime.Now;
                record.Valid = true;
                DbCache.SetRecord(key, record);
            }
            return (TQuestionnaireStatus)record.Value;
        }

        public static TQuestionnaireStatus Create()
        {
            TQuestionnaireStatus result = new TQuestionnaireStatus();
            result.LoadDefaultValues();
            return result;
        }

        public static DbTable<TQuestionnaireStatus> LoadAll()
        {
            DbTable<TQuestionnaireStatus> table = new DbTable<TQuestionnaireStatus>();
            TQuestionnaireStatus prototype = new TQuestionnaireStatus();
            prototype.LoadTable(table);
            return table;
        }

        public static DbTable<TQuestionnaireStatus> LoadBy(string whereCondition, params object[] parameterValues)
        {
            DbTable<TQuestionnaireStatus> table = new DbTable<TQuestionnaireStatus>();
            TQuestionnaireStatus prototype = new TQuestionnaireStatus();
            prototype.LoadTable(table, whereCondition, parameterValues);
            return table;
        }
    }

    public class TPDMStatusPhoto: DbObject
    {
        private static DbSchema schema = null;

        public int IDPDMStatusPhoto
        {
            get { return DbConverter.ToInt(this["IDPDMStatusPhoto"]); }
            set { this["IDPDMStatusPhoto"] = DbConverter.FromInt(value); }
        }

        public string PDMStatusPhoto
        {
            get { return DbConverter.ToString(this["PDMStatusPhoto"]); }
            set { this["PDMStatusPhoto"] = DbConverter.FromString(value); }
        }

        protected override DbSchema GetSchema()
        {
            if (schema == null)
            {
                schema = new DbSchema("TPDMStatusPhoto");
                schema.Add("IDPDMStatusPhoto", typeof(int), "IDPDMStatusPhoto", false, true, true);
                schema.Add("PDMStatusPhoto", typeof(string), "PDMStatusPhoto", false);
            }

            return schema;
        }

        public override void LoadDefaultValues()
        {
            SqlCommand command = Session.CreateCommand();

            this["IDPDMStatusPhoto"] = DbConverter.DefaultInt();

            this["PDMStatusPhoto"] = DbConverter.DefaultString();
        }

        public static TPDMStatusPhoto Load(int iDPDMStatusPhoto)
        {
            TPDMStatusPhoto result = new TPDMStatusPhoto();
            result.LoadRecord(iDPDMStatusPhoto);
            return result;
        }

        public static TPDMStatusPhoto CachedLoad(int iDPDMStatusPhoto)
        {
            DbCache.TableKey key = new DbCache.TableKey("TPDMStatusPhoto");
            DbCache.CacheRecord record;
            key.Set(iDPDMStatusPhoto);
            if (DbCache.Contains(key))
            {
                record = DbCache.GetRecord(key);
                if (!record.IsValid())
                {
                    record.Value = Load(iDPDMStatusPhoto);
                    record.LastUpdate = DateTime.Now;
                    record.Valid = true;
                }
            }
            else
            {
                record = new DbCache.CacheRecord();
                record.Value = Load(iDPDMStatusPhoto);
                record.LastUpdate = DateTime.Now;
                record.Valid = true;
                DbCache.SetRecord(key, record);
            }
            return (TPDMStatusPhoto)record.Value;
        }

        public static TPDMStatusPhoto Create()
        {
            TPDMStatusPhoto result = new TPDMStatusPhoto();
            result.LoadDefaultValues();
            return result;
        }

        public static DbTable<TPDMStatusPhoto> LoadAll()
        {
            DbTable<TPDMStatusPhoto> table = new DbTable<TPDMStatusPhoto>();
            TPDMStatusPhoto prototype = new TPDMStatusPhoto();
            prototype.LoadTable(table);
            return table;
        }

        public static DbTable<TPDMStatusPhoto> LoadBy(string whereCondition, params object[] parameterValues)
        {
            DbTable<TPDMStatusPhoto> table = new DbTable<TPDMStatusPhoto>();
            TPDMStatusPhoto prototype = new TPDMStatusPhoto();
            prototype.LoadTable(table, whereCondition, parameterValues);
            return table;
        }
    }

    public class TRevisionType: DbObject
    {
        private static DbSchema schema = null;

        public int RevisionTypeID
        {
            get { return DbConverter.ToInt(this["RevisionTypeID"]); }
            set { this["RevisionTypeID"] = DbConverter.FromInt(value); }
        }

        public string RevisionTypeName
        {
            get { return DbConverter.ToString(this["RevisionTypeName"]); }
            set { this["RevisionTypeName"] = DbConverter.FromString(value); }
        }

        protected override DbSchema GetSchema()
        {
            if (schema == null)
            {
                schema = new DbSchema("TRevisionType");
                schema.Add("RevisionTypeID", typeof(int), "RevisionTypeID", false, true, false);
                schema.Add("RevisionTypeName", typeof(string), "RevisionTypeName", false);
            }

            return schema;
        }

        public override void LoadDefaultValues()
        {
            SqlCommand command = Session.CreateCommand();

            this["RevisionTypeID"] = DbConverter.DefaultInt();

            this["RevisionTypeName"] = DbConverter.DefaultString();
        }

        public static TRevisionType Load(int revisionTypeID)
        {
            TRevisionType result = new TRevisionType();
            result.LoadRecord(revisionTypeID);
            return result;
        }

        public static TRevisionType CachedLoad(int revisionTypeID)
        {
            DbCache.TableKey key = new DbCache.TableKey("TRevisionType");
            DbCache.CacheRecord record;
            key.Set(revisionTypeID);
            if (DbCache.Contains(key))
            {
                record = DbCache.GetRecord(key);
                if (!record.IsValid())
                {
                    record.Value = Load(revisionTypeID);
                    record.LastUpdate = DateTime.Now;
                    record.Valid = true;
                }
            }
            else
            {
                record = new DbCache.CacheRecord();
                record.Value = Load(revisionTypeID);
                record.LastUpdate = DateTime.Now;
                record.Valid = true;
                DbCache.SetRecord(key, record);
            }
            return (TRevisionType)record.Value;
        }

        public static TRevisionType Create()
        {
            TRevisionType result = new TRevisionType();
            result.LoadDefaultValues();
            return result;
        }

        public static DbTable<TRevisionType> LoadAll()
        {
            DbTable<TRevisionType> table = new DbTable<TRevisionType>();
            TRevisionType prototype = new TRevisionType();
            prototype.LoadTable(table);
            return table;
        }

        public static DbTable<TRevisionType> LoadBy(string whereCondition, params object[] parameterValues)
        {
            DbTable<TRevisionType> table = new DbTable<TRevisionType>();
            TRevisionType prototype = new TRevisionType();
            prototype.LoadTable(table, whereCondition, parameterValues);
            return table;
        }
    }

    public class _ImportSLFinal: DbObject
    {
        private static DbSchema schema = null;

        public DbNullable<string> CIsloSetu
        {
            get { return DbConverter.ToStringNull(this["CIsloSetu"]); }
            set { this["CIsloSetu"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> Země
        {
            get { return DbConverter.ToStringNull(this["Země"]); }
            set { this["Země"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> StatusSetu
        {
            get { return DbConverter.ToStringNull(this["StatusSetu"]); }
            set { this["StatusSetu"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<double> PocetkKsDoKrabice
        {
            get { return DbConverter.ToDoubleNull(this["PocetkKsDoKrabice"]); }
            set { this["PocetkKsDoKrabice"] = DbConverter.FromDoubleNull(value); }
        }

        public DbNullable<string> VelikostKrabice
        {
            get { return DbConverter.ToStringNull(this["VelikostKrabice"]); }
            set { this["VelikostKrabice"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> DruhBaleni
        {
            get { return DbConverter.ToStringNull(this["DruhBaleni"]); }
            set { this["DruhBaleni"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> MetodaBaleniHlavni
        {
            get { return DbConverter.ToStringNull(this["MetodaBaleniHlavni"]); }
            set { this["MetodaBaleniHlavni"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> MetodaBaleniVedlejsi
        {
            get { return DbConverter.ToStringNull(this["MetodaBaleniVedlejsi"]); }
            set { this["MetodaBaleniVedlejsi"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> BreatherBag
        {
            get { return DbConverter.ToStringNull(this["BreatherBag"]); }
            set { this["BreatherBag"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<double> Sirka
        {
            get { return DbConverter.ToDoubleNull(this["Sirka"]); }
            set { this["Sirka"] = DbConverter.FromDoubleNull(value); }
        }

        public DbNullable<double> Delka
        {
            get { return DbConverter.ToDoubleNull(this["Delka"]); }
            set { this["Delka"] = DbConverter.FromDoubleNull(value); }
        }

        public DbNullable<double> Vyska
        {
            get { return DbConverter.ToDoubleNull(this["Vyska"]); }
            set { this["Vyska"] = DbConverter.FromDoubleNull(value); }
        }

        public DbNullable<double> VahaRucne
        {
            get { return DbConverter.ToDoubleNull(this["VahaRucne"]); }
            set { this["VahaRucne"] = DbConverter.FromDoubleNull(value); }
        }

        // TODO remove ()
        public DbNullable<string> váha_setu_stáhnutá_g
        {
            get { return DbConverter.ToStringNull(this["váha setu stáhnutá g"]); }
            set { this["váha setu stáhnutá g"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> Poznamka
        {
            get { return DbConverter.ToStringNull(this["Poznamka"]); }
            set { this["Poznamka"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> KdoZpracovalWI
        {
            get { return DbConverter.ToStringNull(this["KdoZpracovalWI"]); }
            set { this["KdoZpracovalWI"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<DateTime> DatumZpracovaniWI
        {
            get { return DbConverter.ToDateTimeNull(this["DatumZpracovaniWI"]); }
            set { this["DatumZpracovaniWI"] = DbConverter.FromDateTimeNull(value); }
        }

        public DbNullable<string> DatumSchvaleniWI
        {
            get { return DbConverter.ToStringNull(this["DatumSchvaleniWI"]); }
            set { this["DatumSchvaleniWI"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> SchvalilWI
        {
            get { return DbConverter.ToStringNull(this["SchvalilWI"]); }
            set { this["SchvalilWI"] = DbConverter.FromStringNull(value); }
        }

        protected override DbSchema GetSchema()
        {
            if (schema == null)
            {
                schema = new DbSchema("_ImportSLFinal");
                schema.Add("CIsloSetu", typeof(string), "CIsloSetu", true);
                schema.Add("Země", typeof(string), "Země", true);
                schema.Add("StatusSetu", typeof(string), "StatusSetu", true);
                schema.Add("PocetkKsDoKrabice", typeof(double), "PocetkKsDoKrabice", true);
                schema.Add("VelikostKrabice", typeof(string), "VelikostKrabice", true);
                schema.Add("DruhBaleni", typeof(string), "DruhBaleni", true);
                schema.Add("MetodaBaleniHlavni", typeof(string), "MetodaBaleniHlavni", true);
                schema.Add("MetodaBaleniVedlejsi", typeof(string), "MetodaBaleniVedlejsi", true);
                schema.Add("BreatherBag", typeof(string), "BreatherBag", true);
                schema.Add("Sirka", typeof(double), "Sirka", true);
                schema.Add("Delka", typeof(double), "Delka", true);
                schema.Add("Vyska", typeof(double), "Vyska", true);
                schema.Add("VahaRucne", typeof(double), "VahaRucne", true);
                schema.Add("váha setu stáhnutá (g)", typeof(string), "váha setu stáhnutá (g)", true);
                schema.Add("Poznamka", typeof(string), "Poznamka", true);
                schema.Add("KdoZpracovalWI", typeof(string), "KdoZpracovalWI", true);
                schema.Add("DatumZpracovaniWI", typeof(DateTime), "DatumZpracovaniWI", true);
                schema.Add("DatumSchvaleniWI", typeof(string), "DatumSchvaleniWI", true);
                schema.Add("SchvalilWI", typeof(string), "SchvalilWI", true);
            }

            return schema;
        }

        public override void LoadDefaultValues()
        {
            SqlCommand command = Session.CreateCommand();

            this["CIsloSetu"] = DBNull.Value;

            this["Země"] = DBNull.Value;

            this["StatusSetu"] = DBNull.Value;

            this["PocetkKsDoKrabice"] = DBNull.Value;

            this["VelikostKrabice"] = DBNull.Value;

            this["DruhBaleni"] = DBNull.Value;

            this["MetodaBaleniHlavni"] = DBNull.Value;

            this["MetodaBaleniVedlejsi"] = DBNull.Value;

            this["BreatherBag"] = DBNull.Value;

            this["Sirka"] = DBNull.Value;

            this["Delka"] = DBNull.Value;

            this["Vyska"] = DBNull.Value;

            this["VahaRucne"] = DBNull.Value;

            this["váha setu stáhnutá (g)"] = DBNull.Value;

            this["Poznamka"] = DBNull.Value;

            this["KdoZpracovalWI"] = DBNull.Value;

            this["DatumZpracovaniWI"] = DBNull.Value;

            this["DatumSchvaleniWI"] = DBNull.Value;

            this["SchvalilWI"] = DBNull.Value;
        }

        public static _ImportSLFinal Load()
        {
            _ImportSLFinal result = new _ImportSLFinal();
            result.LoadRecord();
            return result;
        }

        public static _ImportSLFinal CachedLoad()
        {
            DbCache.TableKey key = new DbCache.TableKey("_ImportSLFinal");
            DbCache.CacheRecord record;
            key.Set();
            if (DbCache.Contains(key))
            {
                record = DbCache.GetRecord(key);
                if (!record.IsValid())
                {
                    record.Value = Load();
                    record.LastUpdate = DateTime.Now;
                    record.Valid = true;
                }
            }
            else
            {
                record = new DbCache.CacheRecord();
                record.Value = Load();
                record.LastUpdate = DateTime.Now;
                record.Valid = true;
                DbCache.SetRecord(key, record);
            }
            return (_ImportSLFinal)record.Value;
        }

        public static _ImportSLFinal Create()
        {
            _ImportSLFinal result = new _ImportSLFinal();
            result.LoadDefaultValues();
            return result;
        }

        public static DbTable<_ImportSLFinal> LoadAll()
        {
            DbTable<_ImportSLFinal> table = new DbTable<_ImportSLFinal>();
            _ImportSLFinal prototype = new _ImportSLFinal();
            prototype.LoadTable(table);
            return table;
        }

        public static DbTable<_ImportSLFinal> LoadBy(string whereCondition, params object[] parameterValues)
        {
            DbTable<_ImportSLFinal> table = new DbTable<_ImportSLFinal>();
            _ImportSLFinal prototype = new _ImportSLFinal();
            prototype.LoadTable(table, whereCondition, parameterValues);
            return table;
        }
    }

    public class TQDate: DbObject
    {
        private static DbSchema schema = null;

        public int id
        {
            get { return DbConverter.ToInt(this["id"]); }
            set { this["id"] = DbConverter.FromInt(value); }
        }

        public string Code
        {
            get { return DbConverter.ToString(this["Code"]); }
            set { this["Code"] = DbConverter.FromString(value); }
        }

        public DbNullable<DateTime> QDate
        {
            get { return DbConverter.ToDateTimeNull(this["QDate"]); }
            set { this["QDate"] = DbConverter.FromDateTimeNull(value); }
        }

        public DbNullable<string> Residuals
        {
            get { return DbConverter.ToStringNull(this["Residuals"]); }
            set { this["Residuals"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> QDateStr
        {
            get { return DbConverter.ToStringNull(this["QDateStr"]); }
            set { this["QDateStr"] = DbConverter.FromStringNull(value); }
        }

        protected override DbSchema GetSchema()
        {
            if (schema == null)
            {
                schema = new DbSchema("TQDate");
                schema.Add("id", typeof(int), "id", false, false, true);
                schema.Add("Code", typeof(string), "Code", false, true, false);
                schema.Add("QDate", typeof(DateTime), "QDate", true);
                schema.Add("Residuals", typeof(string), "Residuals", true);
                schema.Add("QDateStr", typeof(string), "QDateStr", true);
            }

            return schema;
        }

        public override void LoadDefaultValues()
        {
            SqlCommand command = Session.CreateCommand();

            this["id"] = DbConverter.DefaultInt();

            this["Code"] = DbConverter.DefaultString();

            this["QDate"] = DBNull.Value;

            this["Residuals"] = DBNull.Value;

            this["QDateStr"] = DBNull.Value;
        }

        public static TQDate Load(string code)
        {
            TQDate result = new TQDate();
            result.LoadRecord(code);
            return result;
        }

        public static TQDate CachedLoad(string code)
        {
            DbCache.TableKey key = new DbCache.TableKey("TQDate");
            DbCache.CacheRecord record;
            key.Set(code);
            if (DbCache.Contains(key))
            {
                record = DbCache.GetRecord(key);
                if (!record.IsValid())
                {
                    record.Value = Load(code);
                    record.LastUpdate = DateTime.Now;
                    record.Valid = true;
                }
            }
            else
            {
                record = new DbCache.CacheRecord();
                record.Value = Load(code);
                record.LastUpdate = DateTime.Now;
                record.Valid = true;
                DbCache.SetRecord(key, record);
            }
            return (TQDate)record.Value;
        }

        public static TQDate Create()
        {
            TQDate result = new TQDate();
            result.LoadDefaultValues();
            return result;
        }

        public static DbTable<TQDate> LoadAll()
        {
            DbTable<TQDate> table = new DbTable<TQDate>();
            TQDate prototype = new TQDate();
            prototype.LoadTable(table);
            return table;
        }

        public static DbTable<TQDate> LoadBy(string whereCondition, params object[] parameterValues)
        {
            DbTable<TQDate> table = new DbTable<TQDate>();
            TQDate prototype = new TQDate();
            prototype.LoadTable(table, whereCondition, parameterValues);
            return table;
        }
    }

    public class TSampleList: DbObject
    {
        private static DbSchema schema = null;

        public int IDSampleList
        {
            get { return DbConverter.ToInt(this["IDSampleList"]); }
            set { this["IDSampleList"] = DbConverter.FromInt(value); }
        }

        public DbNullable<int> VyskladneniLast
        {
            get { return DbConverter.ToIntNull(this["VyskladneniLast"]); }
            set { this["VyskladneniLast"] = DbConverter.FromIntNull(value); }
        }

        public DbNullable<string> CisloSetu
        {
            get { return DbConverter.ToStringNull(this["CisloSetu"]); }
            set { this["CisloSetu"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<DateTime> Created
        {
            get { return DbConverter.ToDateTimeNull(this["Created"]); }
            set { this["Created"] = DbConverter.FromDateTimeNull(value); }
        }

        public DbNullable<int> CreatedBy
        {
            get { return DbConverter.ToIntNull(this["CreatedBy"]); }
            set { this["CreatedBy"] = DbConverter.FromIntNull(value); }
        }

        public DbNullable<int> Zeme
        {
            get { return DbConverter.ToIntNull(this["Zeme"]); }
            set { this["Zeme"] = DbConverter.FromIntNull(value); }
        }

        public DbNullable<int> StatusSet
        {
            get { return DbConverter.ToIntNull(this["StatusSet"]); }
            set { this["StatusSet"] = DbConverter.FromIntNull(value); }
        }

        public DbNullable<decimal> WidthSet
        {
            get { return DbConverter.ToDecimalNull(this["WidthSet"]); }
            set { this["WidthSet"] = DbConverter.FromDecimalNull(value); }
        }

        public DbNullable<int> LengthSet
        {
            get { return DbConverter.ToIntNull(this["LengthSet"]); }
            set { this["LengthSet"] = DbConverter.FromIntNull(value); }
        }

        public DbNullable<int> HeightSet
        {
            get { return DbConverter.ToIntNull(this["HeightSet"]); }
            set { this["HeightSet"] = DbConverter.FromIntNull(value); }
        }

        public DbNullable<int> NumberInBox
        {
            get { return DbConverter.ToIntNull(this["NumberInBox"]); }
            set { this["NumberInBox"] = DbConverter.FromIntNull(value); }
        }

        public DbNullable<int> TypeOfPackaging
        {
            get { return DbConverter.ToIntNull(this["TypeOfPackaging"]); }
            set { this["TypeOfPackaging"] = DbConverter.FromIntNull(value); }
        }

        public DbNullable<string> MethodOfPackaging
        {
            get { return DbConverter.ToStringNull(this["MethodOfPackaging"]); }
            set { this["MethodOfPackaging"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<int> BreatherBag
        {
            get { return DbConverter.ToIntNull(this["BreatherBag"]); }
            set { this["BreatherBag"] = DbConverter.FromIntNull(value); }
        }

        public DbNullable<int> SizeOfBox
        {
            get { return DbConverter.ToIntNull(this["SizeOfBox"]); }
            set { this["SizeOfBox"] = DbConverter.FromIntNull(value); }
        }

        public DbNullable<decimal> _WeightSetManually
        {
            get { return DbConverter.ToDecimalNull(this["_WeightSetManually"]); }
            set { this["_WeightSetManually"] = DbConverter.FromDecimalNull(value); }
        }

        public DbNullable<decimal> WeightSet2
        {
            get { return DbConverter.ToDecimalNull(this["WeightSet2"]); }
            set { this["WeightSet2"] = DbConverter.FromDecimalNull(value); }
        }

        public DbNullable<string> NoteSet
        {
            get { return DbConverter.ToStringNull(this["NoteSet"]); }
            set { this["NoteSet"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<int> WhoWorked
        {
            get { return DbConverter.ToIntNull(this["WhoWorked"]); }
            set { this["WhoWorked"] = DbConverter.FromIntNull(value); }
        }

        public DbNullable<DateTime> DateOfProcessing
        {
            get { return DbConverter.ToDateTimeNull(this["DateOfProcessing"]); }
            set { this["DateOfProcessing"] = DbConverter.FromDateTimeNull(value); }
        }

        public DbNullable<int> WhoApproved
        {
            get { return DbConverter.ToIntNull(this["WhoApproved"]); }
            set { this["WhoApproved"] = DbConverter.FromIntNull(value); }
        }

        public DbNullable<DateTime> DateOfApproval
        {
            get { return DbConverter.ToDateTimeNull(this["DateOfApproval"]); }
            set { this["DateOfApproval"] = DbConverter.FromDateTimeNull(value); }
        }

        public DbNullable<bool> PostedWi
        {
            get { return DbConverter.ToBoolNull(this["PostedWi"]); }
            set { this["PostedWi"] = DbConverter.FromBoolNull(value); }
        }

        public DbNullable<string> NoteForApproval
        {
            get { return DbConverter.ToStringNull(this["NoteForApproval"]); }
            set { this["NoteForApproval"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> MethodOfPackagingMain
        {
            get { return DbConverter.ToStringNull(this["MethodOfPackagingMain"]); }
            set { this["MethodOfPackagingMain"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> MethodOfPackagingSecondary
        {
            get { return DbConverter.ToStringNull(this["MethodOfPackagingSecondary"]); }
            set { this["MethodOfPackagingSecondary"] = DbConverter.FromStringNull(value); }
        }

        protected override DbSchema GetSchema()
        {
            if (schema == null)
            {
                schema = new DbSchema("TSampleList");
                schema.Add("IDSampleList", typeof(int), "IDSampleList", false, true, true);
                schema.Add("VyskladneniLast", typeof(int), "VyskladneniLast", true);
                schema.Add("CisloSetu", typeof(string), "CisloSetu", true);
                schema.Add("Created", typeof(DateTime), "Created", true);
                schema.Add("CreatedBy", typeof(int), "CreatedBy", true);
                schema.Add("Zeme", typeof(int), "Zeme", true);
                schema.Add("StatusSet", typeof(int), "StatusSet", true);
                schema.Add("WidthSet", typeof(decimal), "WidthSet", true);
                schema.Add("LengthSet", typeof(int), "LengthSet", true);
                schema.Add("HeightSet", typeof(int), "HeightSet", true);
                schema.Add("NumberInBox", typeof(int), "NumberInBox", true);
                schema.Add("TypeOfPackaging", typeof(int), "TypeOfPackaging", true);
                schema.Add("MethodOfPackaging", typeof(string), "MethodOfPackaging", true);
                schema.Add("BreatherBag", typeof(int), "BreatherBag", true);
                schema.Add("SizeOfBox", typeof(int), "SizeOfBox", true);
                schema.Add("_WeightSetManually", typeof(decimal), "_WeightSetManually", true);
                schema.Add("WeightSet2", typeof(decimal), "WeightSet2", true);
                schema.Add("NoteSet", typeof(string), "NoteSet", true);
                schema.Add("WhoWorked", typeof(int), "WhoWorked", true);
                schema.Add("DateOfProcessing", typeof(DateTime), "DateOfProcessing", true);
                schema.Add("WhoApproved", typeof(int), "WhoApproved", true);
                schema.Add("DateOfApproval", typeof(DateTime), "DateOfApproval", true);
                schema.Add("PostedWi", typeof(bool), "PostedWi", true);
                schema.Add("NoteForApproval", typeof(string), "NoteForApproval", true);
                schema.Add("MethodOfPackagingMain", typeof(string), "MethodOfPackagingMain", true);
                schema.Add("MethodOfPackagingSecondary", typeof(string), "MethodOfPackagingSecondary", true);
            }

            return schema;
        }

        public override void LoadDefaultValues()
        {
            SqlCommand command = Session.CreateCommand();

            this["IDSampleList"] = DbConverter.DefaultInt();

            this["VyskladneniLast"] = DBNull.Value;

            this["CisloSetu"] = DBNull.Value;

            command.CommandText = "SELECT (getdate())";
            this["Created"] = command.ExecuteScalar();

            this["CreatedBy"] = DBNull.Value;

            this["Zeme"] = DBNull.Value;

            this["StatusSet"] = DBNull.Value;

            this["WidthSet"] = DBNull.Value;

            this["LengthSet"] = DBNull.Value;

            this["HeightSet"] = DBNull.Value;

            this["NumberInBox"] = DBNull.Value;

            this["TypeOfPackaging"] = DBNull.Value;

            this["MethodOfPackaging"] = DBNull.Value;

            this["BreatherBag"] = DBNull.Value;

            this["SizeOfBox"] = DBNull.Value;

            this["_WeightSetManually"] = DBNull.Value;

            this["WeightSet2"] = DBNull.Value;

            this["NoteSet"] = DBNull.Value;

            this["WhoWorked"] = DBNull.Value;

            this["DateOfProcessing"] = DBNull.Value;

            this["WhoApproved"] = DBNull.Value;

            this["DateOfApproval"] = DBNull.Value;

            command.CommandText = "SELECT ((0))";
            this["PostedWi"] = command.ExecuteScalar();

            this["NoteForApproval"] = DBNull.Value;

            this["MethodOfPackagingMain"] = DBNull.Value;

            this["MethodOfPackagingSecondary"] = DBNull.Value;
        }

        public static TSampleList Load(int iDSampleList)
        {
            TSampleList result = new TSampleList();
            result.LoadRecord(iDSampleList);
            return result;
        }

        public static TSampleList CachedLoad(int iDSampleList)
        {
            DbCache.TableKey key = new DbCache.TableKey("TSampleList");
            DbCache.CacheRecord record;
            key.Set(iDSampleList);
            if (DbCache.Contains(key))
            {
                record = DbCache.GetRecord(key);
                if (!record.IsValid())
                {
                    record.Value = Load(iDSampleList);
                    record.LastUpdate = DateTime.Now;
                    record.Valid = true;
                }
            }
            else
            {
                record = new DbCache.CacheRecord();
                record.Value = Load(iDSampleList);
                record.LastUpdate = DateTime.Now;
                record.Valid = true;
                DbCache.SetRecord(key, record);
            }
            return (TSampleList)record.Value;
        }

        public static TSampleList Create()
        {
            TSampleList result = new TSampleList();
            result.LoadDefaultValues();
            return result;
        }

        public static DbTable<TSampleList> LoadAll()
        {
            DbTable<TSampleList> table = new DbTable<TSampleList>();
            TSampleList prototype = new TSampleList();
            prototype.LoadTable(table);
            return table;
        }

        public static DbTable<TSampleList> LoadByVyskladneniLast(DbNullable<int> vyskladneniLast)
        {
            DbTable<TSampleList> table = new DbTable<TSampleList>();
            TSampleList prototype = new TSampleList();
            prototype.LoadTable(table, "[VyskladneniLast]={0}", DbConverter.FromIntNull(vyskladneniLast));
            return table;
        }

        public static DbTable<TSampleList> LoadByCreatedBy(DbNullable<int> createdBy)
        {
            DbTable<TSampleList> table = new DbTable<TSampleList>();
            TSampleList prototype = new TSampleList();
            prototype.LoadTable(table, "[CreatedBy]={0}", DbConverter.FromIntNull(createdBy));
            return table;
        }

        public static DbTable<TSampleList> LoadByZeme(DbNullable<int> zeme)
        {
            DbTable<TSampleList> table = new DbTable<TSampleList>();
            TSampleList prototype = new TSampleList();
            prototype.LoadTable(table, "[Zeme]={0}", DbConverter.FromIntNull(zeme));
            return table;
        }

        public static DbTable<TSampleList> LoadByStatusSet(DbNullable<int> statusSet)
        {
            DbTable<TSampleList> table = new DbTable<TSampleList>();
            TSampleList prototype = new TSampleList();
            prototype.LoadTable(table, "[StatusSet]={0}", DbConverter.FromIntNull(statusSet));
            return table;
        }

        public static DbTable<TSampleList> LoadByTypeOfPackaging(DbNullable<int> typeOfPackaging)
        {
            DbTable<TSampleList> table = new DbTable<TSampleList>();
            TSampleList prototype = new TSampleList();
            prototype.LoadTable(table, "[TypeOfPackaging]={0}", DbConverter.FromIntNull(typeOfPackaging));
            return table;
        }

        public static DbTable<TSampleList> LoadByBreatherBag(DbNullable<int> breatherBag)
        {
            DbTable<TSampleList> table = new DbTable<TSampleList>();
            TSampleList prototype = new TSampleList();
            prototype.LoadTable(table, "[BreatherBag]={0}", DbConverter.FromIntNull(breatherBag));
            return table;
        }

        public static DbTable<TSampleList> LoadBySizeOfBox(DbNullable<int> sizeOfBox)
        {
            DbTable<TSampleList> table = new DbTable<TSampleList>();
            TSampleList prototype = new TSampleList();
            prototype.LoadTable(table, "[SizeOfBox]={0}", DbConverter.FromIntNull(sizeOfBox));
            return table;
        }

        public static DbTable<TSampleList> LoadByWhoWorked(DbNullable<int> whoWorked)
        {
            DbTable<TSampleList> table = new DbTable<TSampleList>();
            TSampleList prototype = new TSampleList();
            prototype.LoadTable(table, "[WhoWorked]={0}", DbConverter.FromIntNull(whoWorked));
            return table;
        }

        public static DbTable<TSampleList> LoadByWhoApproved(DbNullable<int> whoApproved)
        {
            DbTable<TSampleList> table = new DbTable<TSampleList>();
            TSampleList prototype = new TSampleList();
            prototype.LoadTable(table, "[WhoApproved]={0}", DbConverter.FromIntNull(whoApproved));
            return table;
        }

        public static DbTable<TSampleList> LoadBy(string whereCondition, params object[] parameterValues)
        {
            DbTable<TSampleList> table = new DbTable<TSampleList>();
            TSampleList prototype = new TSampleList();
            prototype.LoadTable(table, whereCondition, parameterValues);
            return table;
        }
    }

    public class TComponents: DbObject
    {
        private static DbSchema schema = null;

        public int ComponentID
        {
            get { return DbConverter.ToInt(this["ComponentID"]); }
            set { this["ComponentID"] = DbConverter.FromInt(value); }
        }

        public string Code
        {
            get { return DbConverter.ToString(this["Code"]); }
            set { this["Code"] = DbConverter.FromString(value); }
        }

        public DbNullable<string> Vendor
        {
            get { return DbConverter.ToStringNull(this["Vendor"]); }
            set { this["Vendor"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> Description
        {
            get { return DbConverter.ToStringNull(this["Description"]); }
            set { this["Description"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<int> Supplier
        {
            get { return DbConverter.ToIntNull(this["Supplier"]); }
            set { this["Supplier"] = DbConverter.FromIntNull(value); }
        }

        public DbNullable<int> Manufacturer
        {
            get { return DbConverter.ToIntNull(this["Manufacturer"]); }
            set { this["Manufacturer"] = DbConverter.FromIntNull(value); }
        }

        public DbNullable<int> Responsible
        {
            get { return DbConverter.ToIntNull(this["Responsible"]); }
            set { this["Responsible"] = DbConverter.FromIntNull(value); }
        }

        public DbNullable<string> Issue
        {
            get { return DbConverter.ToStringNull(this["Issue"]); }
            set { this["Issue"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> Class
        {
            get { return DbConverter.ToStringNull(this["Class"]); }
            set { this["Class"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> CEMark
        {
            get { return DbConverter.ToStringNull(this["CEMark"]); }
            set { this["CEMark"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<DateTime> ExpiryDate
        {
            get { return DbConverter.ToDateTimeNull(this["ExpiryDate"]); }
            set { this["ExpiryDate"] = DbConverter.FromDateTimeNull(value); }
        }

        public DbNullable<string> CompatibleETO
        {
            get { return DbConverter.ToStringNull(this["CompatibleETO"]); }
            set { this["CompatibleETO"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> ProdApprov
        {
            get { return DbConverter.ToStringNull(this["ProdApprov"]); }
            set { this["ProdApprov"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> PhCheckInWareHouse
        {
            get { return DbConverter.ToStringNull(this["PhCheckInWareHouse"]); }
            set { this["PhCheckInWareHouse"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> Comments
        {
            get { return DbConverter.ToStringNull(this["Comments"]); }
            set { this["Comments"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> Questionnaire
        {
            get { return DbConverter.ToStringNull(this["Questionnaire"]); }
            set { this["Questionnaire"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<DateTime> SetUpDate
        {
            get { return DbConverter.ToDateTimeNull(this["SetUpDate"]); }
            set { this["SetUpDate"] = DbConverter.FromDateTimeNull(value); }
        }

        public DbNullable<DateTime> ApprovalDate
        {
            get { return DbConverter.ToDateTimeNull(this["ApprovalDate"]); }
            set { this["ApprovalDate"] = DbConverter.FromDateTimeNull(value); }
        }

        public DbNullable<DateTime> TrackingDate
        {
            get { return DbConverter.ToDateTimeNull(this["TrackingDate"]); }
            set { this["TrackingDate"] = DbConverter.FromDateTimeNull(value); }
        }

        public DbNullable<string> MaterComp
        {
            get { return DbConverter.ToStringNull(this["MaterComp"]); }
            set { this["MaterComp"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> PVC
        {
            get { return DbConverter.ToStringNull(this["PVC"]); }
            set { this["PVC"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> Phtalates
        {
            get { return DbConverter.ToStringNull(this["Phtalates"]); }
            set { this["Phtalates"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> LatexInComp
        {
            get { return DbConverter.ToStringNull(this["LatexInComp"]); }
            set { this["LatexInComp"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> LatexInPack
        {
            get { return DbConverter.ToStringNull(this["LatexInPack"]); }
            set { this["LatexInPack"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> Pyrogen
        {
            get { return DbConverter.ToStringNull(this["Pyrogen"]); }
            set { this["Pyrogen"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> StorageTemp
        {
            get { return DbConverter.ToStringNull(this["StorageTemp"]); }
            set { this["StorageTemp"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> OtherStorageCond
        {
            get { return DbConverter.ToStringNull(this["OtherStorageCond"]); }
            set { this["OtherStorageCond"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> MaxSterilVacuum
        {
            get { return DbConverter.ToStringNull(this["MaxSterilVacuum"]); }
            set { this["MaxSterilVacuum"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<int> PDMStatus
        {
            get { return DbConverter.ToIntNull(this["PDMStatus"]); }
            set { this["PDMStatus"] = DbConverter.FromIntNull(value); }
        }

        public DbNullable<DateTime> ProdApprovPDM
        {
            get { return DbConverter.ToDateTimeNull(this["ProdApprovPDM"]); }
            set { this["ProdApprovPDM"] = DbConverter.FromDateTimeNull(value); }
        }

        public DbNullable<string> TimeForApprov
        {
            get { return DbConverter.ToStringNull(this["TimeForApprov"]); }
            set { this["TimeForApprov"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> IntendedUse
        {
            get { return DbConverter.ToStringNull(this["IntendedUse"]); }
            set { this["IntendedUse"] = DbConverter.FromStringNull(value); }
        }

        public bool Checked
        {
            get { return DbConverter.ToBool(this["Checked"]); }
            set { this["Checked"] = DbConverter.FromBool(value); }
        }

        public DbNullable<int> CheckedBy
        {
            get { return DbConverter.ToIntNull(this["CheckedBy"]); }
            set { this["CheckedBy"] = DbConverter.FromIntNull(value); }
        }

        public DbNullable<string> Material
        {
            get { return DbConverter.ToStringNull(this["Material"]); }
            set { this["Material"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<int> PDMStatusPhotoID
        {
            get { return DbConverter.ToIntNull(this["PDMStatusPhotoID"]); }
            set { this["PDMStatusPhotoID"] = DbConverter.FromIntNull(value); }
        }

        public DbNullable<string> KategorieKomponentu
        {
            get { return DbConverter.ToStringNull(this["KategorieKomponentu"]); }
            set { this["KategorieKomponentu"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> PDMComent
        {
            get { return DbConverter.ToStringNull(this["PDMComent"]); }
            set { this["PDMComent"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> Note
        {
            get { return DbConverter.ToStringNull(this["Note"]); }
            set { this["Note"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> SpecialNote
        {
            get { return DbConverter.ToStringNull(this["SpecialNote"]); }
            set { this["SpecialNote"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> BIN
        {
            get { return DbConverter.ToStringNull(this["BIN"]); }
            set { this["BIN"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> PcsBIN
        {
            get { return DbConverter.ToStringNull(this["PcsBIN"]); }
            set { this["PcsBIN"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<int> VP
        {
            get { return DbConverter.ToIntNull(this["VP"]); }
            set { this["VP"] = DbConverter.FromIntNull(value); }
        }

        public DbNullable<int> KomponentKategorieID
        {
            get { return DbConverter.ToIntNull(this["KomponentKategorieID"]); }
            set { this["KomponentKategorieID"] = DbConverter.FromIntNull(value); }
        }

        public DbNullable<int> FyzickaKontrola
        {
            get { return DbConverter.ToIntNull(this["FyzickaKontrola"]); }
            set { this["FyzickaKontrola"] = DbConverter.FromIntNull(value); }
        }

        public DbNullable<int> VzorovyKomponent
        {
            get { return DbConverter.ToIntNull(this["VzorovyKomponent"]); }
            set { this["VzorovyKomponent"] = DbConverter.FromIntNull(value); }
        }

        public DbNullable<DateTime> NafocenoKdy
        {
            get { return DbConverter.ToDateTimeNull(this["NafocenoKdy"]); }
            set { this["NafocenoKdy"] = DbConverter.FromDateTimeNull(value); }
        }

        public DbNullable<int> NafotilKdoID
        {
            get { return DbConverter.ToIntNull(this["NafotilKdoID"]); }
            set { this["NafotilKdoID"] = DbConverter.FromIntNull(value); }
        }

        public DbNullable<int> Pcs
        {
            get { return DbConverter.ToIntNull(this["Pcs"]); }
            set { this["Pcs"] = DbConverter.FromIntNull(value); }
        }

        public DbNullable<int> DostupnostID
        {
            get { return DbConverter.ToIntNull(this["DostupnostID"]); }
            set { this["DostupnostID"] = DbConverter.FromIntNull(value); }
        }

        public DbNullable<int> PohledT
        {
            get { return DbConverter.ToIntNull(this["PohledT"]); }
            set { this["PohledT"] = DbConverter.FromIntNull(value); }
        }

        public DbNullable<int> PohledTF
        {
            get { return DbConverter.ToIntNull(this["PohledTF"]); }
            set { this["PohledTF"] = DbConverter.FromIntNull(value); }
        }

        public DbNullable<int> PohledC
        {
            get { return DbConverter.ToIntNull(this["PohledC"]); }
            set { this["PohledC"] = DbConverter.FromIntNull(value); }
        }

        public DbNullable<int> PohledSpecial
        {
            get { return DbConverter.ToIntNull(this["PohledSpecial"]); }
            set { this["PohledSpecial"] = DbConverter.FromIntNull(value); }
        }

        public DbNullable<int> PohledCompics
        {
            get { return DbConverter.ToIntNull(this["PohledCompics"]); }
            set { this["PohledCompics"] = DbConverter.FromIntNull(value); }
        }

        public DbNullable<int> KontrolaFotek
        {
            get { return DbConverter.ToIntNull(this["KontrolaFotek"]); }
            set { this["KontrolaFotek"] = DbConverter.FromIntNull(value); }
        }

        public DbNullable<int> Kprefoceni
        {
            get { return DbConverter.ToIntNull(this["Kprefoceni"]); }
            set { this["Kprefoceni"] = DbConverter.FromIntNull(value); }
        }

        public DbNullable<DateTime> _PrefocenoKdy
        {
            get { return DbConverter.ToDateTimeNull(this["_PrefocenoKdy"]); }
            set { this["_PrefocenoKdy"] = DbConverter.FromDateTimeNull(value); }
        }

        public DbNullable<string> EOD
        {
            get { return DbConverter.ToStringNull(this["EOD"]); }
            set { this["EOD"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<int> SCRAP
        {
            get { return DbConverter.ToIntNull(this["SCRAP"]); }
            set { this["SCRAP"] = DbConverter.FromIntNull(value); }
        }

        public DbNullable<DateTime> SCRAPdate
        {
            get { return DbConverter.ToDateTimeNull(this["SCRAPdate"]); }
            set { this["SCRAPdate"] = DbConverter.FromDateTimeNull(value); }
        }

        public bool New
        {
            get { return DbConverter.ToBool(this["New"]); }
            set { this["New"] = DbConverter.FromBool(value); }
        }

        public DbNullable<string> ReasonSubst
        {
            get { return DbConverter.ToStringNull(this["ReasonSubst"]); }
            set { this["ReasonSubst"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<int> Exter
        {
            get { return DbConverter.ToIntNull(this["Exter"]); }
            set { this["Exter"] = DbConverter.FromIntNull(value); }
        }

        public DbNullable<DateTime> Created
        {
            get { return DbConverter.ToDateTimeNull(this["Created"]); }
            set { this["Created"] = DbConverter.FromDateTimeNull(value); }
        }

        public DbNullable<string> CreatedBy
        {
            get { return DbConverter.ToStringNull(this["CreatedBy"]); }
            set { this["CreatedBy"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<DateTime> QuestionDate
        {
            get { return DbConverter.ToDateTimeNull(this["QuestionDate"]); }
            set { this["QuestionDate"] = DbConverter.FromDateTimeNull(value); }
        }

        public DbNullable<int> QuestionStatus
        {
            get { return DbConverter.ToIntNull(this["QuestionStatus"]); }
            set { this["QuestionStatus"] = DbConverter.FromIntNull(value); }
        }

        public DbNullable<string> Residuals
        {
            get { return DbConverter.ToStringNull(this["Residuals"]); }
            set { this["Residuals"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> VendorPhoto
        {
            get { return DbConverter.ToStringNull(this["VendorPhoto"]); }
            set { this["VendorPhoto"] = DbConverter.FromStringNull(value); }
        }

        public bool ZmenaDesignu
        {
            get { return DbConverter.ToBool(this["ZmenaDesignu"]); }
            set { this["ZmenaDesignu"] = DbConverter.FromBool(value); }
        }

        public DbNullable<DateTime> ZmenaDatum
        {
            get { return DbConverter.ToDateTimeNull(this["ZmenaDatum"]); }
            set { this["ZmenaDatum"] = DbConverter.FromDateTimeNull(value); }
        }

        public DbNullable<string> ZmenaPozn
        {
            get { return DbConverter.ToStringNull(this["ZmenaPozn"]); }
            set { this["ZmenaPozn"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<decimal> Vaha
        {
            get { return DbConverter.ToDecimalNull(this["Vaha"]); }
            set { this["Vaha"] = DbConverter.FromDecimalNull(value); }
        }

        public DbNullable<string> VahaPoznamka
        {
            get { return DbConverter.ToStringNull(this["VahaPoznamka"]); }
            set { this["VahaPoznamka"] = DbConverter.FromStringNull(value); }
        }

        public bool TimeRevision
        {
            get { return DbConverter.ToBool(this["TimeRevision"]); }
            set { this["TimeRevision"] = DbConverter.FromBool(value); }
        }

        public DbNullable<int> PcsBIN2
        {
            get { return DbConverter.ToIntNull(this["PcsBIN2"]); }
            set { this["PcsBIN2"] = DbConverter.FromIntNull(value); }
        }

        protected override DbSchema GetSchema()
        {
            if (schema == null)
            {
                schema = new DbSchema("TComponents");
                schema.Add("ComponentID", typeof(int), "ComponentID", false, true, true);
                schema.Add("Code", typeof(string), "Code", false);
                schema.Add("Vendor", typeof(string), "Vendor", true);
                schema.Add("Description", typeof(string), "Description", true);
                schema.Add("Supplier", typeof(int), "Supplier", true);
                schema.Add("Manufacturer", typeof(int), "Manufacturer", true);
                schema.Add("Responsible", typeof(int), "Responsible", true);
                schema.Add("Issue", typeof(string), "Issue", true);
                schema.Add("Class", typeof(string), "Class", true);
                schema.Add("CEMark", typeof(string), "CEMark", true);
                schema.Add("ExpiryDate", typeof(DateTime), "ExpiryDate", true);
                schema.Add("CompatibleETO", typeof(string), "CompatibleETO", true);
                schema.Add("ProdApprov", typeof(string), "ProdApprov", true);
                schema.Add("PhCheckInWareHouse", typeof(string), "PhCheckInWareHouse", true);
                schema.Add("Comments", typeof(string), "Comments", true);
                schema.Add("Questionnaire", typeof(string), "Questionnaire", true);
                schema.Add("SetUpDate", typeof(DateTime), "SetUpDate", true);
                schema.Add("ApprovalDate", typeof(DateTime), "ApprovalDate", true);
                schema.Add("TrackingDate", typeof(DateTime), "TrackingDate", true);
                schema.Add("MaterComp", typeof(string), "MaterComp", true);
                schema.Add("PVC", typeof(string), "PVC", true);
                schema.Add("Phtalates", typeof(string), "Phtalates", true);
                schema.Add("LatexInComp", typeof(string), "LatexInComp", true);
                schema.Add("LatexInPack", typeof(string), "LatexInPack", true);
                schema.Add("Pyrogen", typeof(string), "Pyrogen", true);
                schema.Add("StorageTemp", typeof(string), "StorageTemp", true);
                schema.Add("OtherStorageCond", typeof(string), "OtherStorageCond", true);
                schema.Add("MaxSterilVacuum", typeof(string), "MaxSterilVacuum", true);
                schema.Add("PDMStatus", typeof(int), "PDMStatus", true);
                schema.Add("ProdApprovPDM", typeof(DateTime), "ProdApprovPDM", true);
                schema.Add("TimeForApprov", typeof(string), "TimeForApprov", true);
                schema.Add("IntendedUse", typeof(string), "IntendedUse", true);
                schema.Add("Checked", typeof(bool), "Checked", false);
                schema.Add("CheckedBy", typeof(int), "CheckedBy", true);
                schema.Add("Material", typeof(string), "Material", true);
                schema.Add("PDMStatusPhotoID", typeof(int), "PDMStatusPhotoID", true);
                schema.Add("KategorieKomponentu", typeof(string), "KategorieKomponentu", true);
                schema.Add("PDMComent", typeof(string), "PDMComent", true);
                schema.Add("Note", typeof(string), "Note", true);
                schema.Add("SpecialNote", typeof(string), "SpecialNote", true);
                schema.Add("BIN", typeof(string), "BIN", true);
                schema.Add("PcsBIN", typeof(string), "PcsBIN", true);
                schema.Add("VP", typeof(int), "VP", true);
                schema.Add("KomponentKategorieID", typeof(int), "KomponentKategorieID", true);
                schema.Add("FyzickaKontrola", typeof(int), "FyzickaKontrola", true);
                schema.Add("VzorovyKomponent", typeof(int), "VzorovyKomponent", true);
                schema.Add("NafocenoKdy", typeof(DateTime), "NafocenoKdy", true);
                schema.Add("NafotilKdoID", typeof(int), "NafotilKdoID", true);
                schema.Add("Pcs", typeof(int), "Pcs", true);
                schema.Add("DostupnostID", typeof(int), "DostupnostID", true);
                schema.Add("PohledT", typeof(int), "PohledT", true);
                schema.Add("PohledTF", typeof(int), "PohledTF", true);
                schema.Add("PohledC", typeof(int), "PohledC", true);
                schema.Add("PohledSpecial", typeof(int), "PohledSpecial", true);
                schema.Add("PohledCompics", typeof(int), "PohledCompics", true);
                schema.Add("KontrolaFotek", typeof(int), "KontrolaFotek", true);
                schema.Add("Kprefoceni", typeof(int), "Kprefoceni", true);
                schema.Add("_PrefocenoKdy", typeof(DateTime), "_PrefocenoKdy", true);
                schema.Add("EOD", typeof(string), "EOD", true);
                schema.Add("SCRAP", typeof(int), "SCRAP", true);
                schema.Add("SCRAPdate", typeof(DateTime), "SCRAPdate", true);
                schema.Add("New", typeof(bool), "New", false);
                schema.Add("ReasonSubst", typeof(string), "ReasonSubst", true);
                schema.Add("Exter", typeof(int), "Exter", true);
                schema.Add("Created", typeof(DateTime), "Created", true);
                schema.Add("CreatedBy", typeof(string), "CreatedBy", true);
                schema.Add("QuestionDate", typeof(DateTime), "QuestionDate", true);
                schema.Add("QuestionStatus", typeof(int), "QuestionStatus", true);
                schema.Add("Residuals", typeof(string), "Residuals", true);
                schema.Add("VendorPhoto", typeof(string), "VendorPhoto", true);
                schema.Add("ZmenaDesignu", typeof(bool), "ZmenaDesignu", false);
                schema.Add("ZmenaDatum", typeof(DateTime), "ZmenaDatum", true);
                schema.Add("ZmenaPozn", typeof(string), "ZmenaPozn", true);
                schema.Add("Vaha", typeof(decimal), "Vaha", true);
                schema.Add("VahaPoznamka", typeof(string), "VahaPoznamka", true);
                schema.Add("TimeRevision", typeof(bool), "TimeRevision", false);
                schema.Add("PcsBIN2", typeof(int), "PcsBIN2", true);
            }

            return schema;
        }

        public override void LoadDefaultValues()
        {
            SqlCommand command = Session.CreateCommand();

            this["ComponentID"] = DbConverter.DefaultInt();

            this["Code"] = DbConverter.DefaultString();

            this["Vendor"] = DBNull.Value;

            this["Description"] = DBNull.Value;

            this["Supplier"] = DBNull.Value;

            this["Manufacturer"] = DBNull.Value;

            this["Responsible"] = DBNull.Value;

            this["Issue"] = DBNull.Value;

            this["Class"] = DBNull.Value;

            this["CEMark"] = DBNull.Value;

            this["ExpiryDate"] = DBNull.Value;

            this["CompatibleETO"] = DBNull.Value;

            this["ProdApprov"] = DBNull.Value;

            this["PhCheckInWareHouse"] = DBNull.Value;

            this["Comments"] = DBNull.Value;

            this["Questionnaire"] = DBNull.Value;

            this["SetUpDate"] = DBNull.Value;

            this["ApprovalDate"] = DBNull.Value;

            this["TrackingDate"] = DBNull.Value;

            this["MaterComp"] = DBNull.Value;

            this["PVC"] = DBNull.Value;

            this["Phtalates"] = DBNull.Value;

            this["LatexInComp"] = DBNull.Value;

            this["LatexInPack"] = DBNull.Value;

            this["Pyrogen"] = DBNull.Value;

            this["StorageTemp"] = DBNull.Value;

            this["OtherStorageCond"] = DBNull.Value;

            this["MaxSterilVacuum"] = DBNull.Value;

            this["PDMStatus"] = DBNull.Value;

            this["ProdApprovPDM"] = DBNull.Value;

            this["TimeForApprov"] = DBNull.Value;

            this["IntendedUse"] = DBNull.Value;

            command.CommandText = "SELECT (1)";
            this["Checked"] = command.ExecuteScalar();

            this["CheckedBy"] = DBNull.Value;

            this["Material"] = DBNull.Value;

            this["PDMStatusPhotoID"] = DBNull.Value;

            this["KategorieKomponentu"] = DBNull.Value;

            this["PDMComent"] = DBNull.Value;

            this["Note"] = DBNull.Value;

            this["SpecialNote"] = DBNull.Value;

            this["BIN"] = DBNull.Value;

            this["PcsBIN"] = DBNull.Value;

            this["VP"] = DBNull.Value;

            this["KomponentKategorieID"] = DBNull.Value;

            this["FyzickaKontrola"] = DBNull.Value;

            this["VzorovyKomponent"] = DBNull.Value;

            this["NafocenoKdy"] = DBNull.Value;

            this["NafotilKdoID"] = DBNull.Value;

            this["Pcs"] = DBNull.Value;

            this["DostupnostID"] = DBNull.Value;

            this["PohledT"] = DBNull.Value;

            this["PohledTF"] = DBNull.Value;

            this["PohledC"] = DBNull.Value;

            this["PohledSpecial"] = DBNull.Value;

            this["PohledCompics"] = DBNull.Value;

            this["KontrolaFotek"] = DBNull.Value;

            this["Kprefoceni"] = DBNull.Value;

            this["_PrefocenoKdy"] = DBNull.Value;

            this["EOD"] = DBNull.Value;

            this["SCRAP"] = DBNull.Value;

            this["SCRAPdate"] = DBNull.Value;

            command.CommandText = "SELECT (1)";
            this["New"] = command.ExecuteScalar();

            this["ReasonSubst"] = DBNull.Value;

            this["Exter"] = DBNull.Value;

            command.CommandText = "SELECT (getdate())";
            this["Created"] = command.ExecuteScalar();

            command.CommandText = "SELECT ([dbo].[FceUserMSSQL]())";
            this["CreatedBy"] = command.ExecuteScalar();

            this["QuestionDate"] = DBNull.Value;

            this["QuestionStatus"] = DBNull.Value;

            this["Residuals"] = DBNull.Value;

            this["VendorPhoto"] = DBNull.Value;

            command.CommandText = "SELECT (0)";
            this["ZmenaDesignu"] = command.ExecuteScalar();

            this["ZmenaDatum"] = DBNull.Value;

            this["ZmenaPozn"] = DBNull.Value;

            this["Vaha"] = DBNull.Value;

            this["VahaPoznamka"] = DBNull.Value;

            command.CommandText = "SELECT ((0))";
            this["TimeRevision"] = command.ExecuteScalar();

            this["PcsBIN2"] = DBNull.Value;
        }

        public static TComponents Load(int componentID)
        {
            TComponents result = new TComponents();
            result.LoadRecord(componentID);
            return result;
        }

        public static TComponents CachedLoad(int componentID)
        {
            DbCache.TableKey key = new DbCache.TableKey("TComponents");
            DbCache.CacheRecord record;
            key.Set(componentID);
            if (DbCache.Contains(key))
            {
                record = DbCache.GetRecord(key);
                if (!record.IsValid())
                {
                    record.Value = Load(componentID);
                    record.LastUpdate = DateTime.Now;
                    record.Valid = true;
                }
            }
            else
            {
                record = new DbCache.CacheRecord();
                record.Value = Load(componentID);
                record.LastUpdate = DateTime.Now;
                record.Valid = true;
                DbCache.SetRecord(key, record);
            }
            return (TComponents)record.Value;
        }

        public static TComponents Create()
        {
            TComponents result = new TComponents();
            result.LoadDefaultValues();
            return result;
        }

        public static DbTable<TComponents> LoadAll()
        {
            DbTable<TComponents> table = new DbTable<TComponents>();
            TComponents prototype = new TComponents();
            prototype.LoadTable(table);
            return table;
        }

        public static DbTable<TComponents> LoadBySupplier(DbNullable<int> supplier)
        {
            DbTable<TComponents> table = new DbTable<TComponents>();
            TComponents prototype = new TComponents();
            prototype.LoadTable(table, "[Supplier]={0}", DbConverter.FromIntNull(supplier));
            return table;
        }

        public static DbTable<TComponents> LoadByManufacturer(DbNullable<int> manufacturer)
        {
            DbTable<TComponents> table = new DbTable<TComponents>();
            TComponents prototype = new TComponents();
            prototype.LoadTable(table, "[Manufacturer]={0}", DbConverter.FromIntNull(manufacturer));
            return table;
        }

        public static DbTable<TComponents> LoadByResponsible(DbNullable<int> responsible)
        {
            DbTable<TComponents> table = new DbTable<TComponents>();
            TComponents prototype = new TComponents();
            prototype.LoadTable(table, "[Responsible]={0}", DbConverter.FromIntNull(responsible));
            return table;
        }

        // TODO class to class_
        public static DbTable<TComponents> LoadByClass(DbNullable<string> class_)
        {
            DbTable<TComponents> table = new DbTable<TComponents>();
            TComponents prototype = new TComponents();
            prototype.LoadTable(table, "[Class]={0}", DbConverter.FromStringNull(class_));
            return table;
        }

        public static DbTable<TComponents> LoadByCEMark(DbNullable<string> cEMark)
        {
            DbTable<TComponents> table = new DbTable<TComponents>();
            TComponents prototype = new TComponents();
            prototype.LoadTable(table, "[CEMark]={0}", DbConverter.FromStringNull(cEMark));
            return table;
        }

        public static DbTable<TComponents> LoadByCompatibleETO(DbNullable<string> compatibleETO)
        {
            DbTable<TComponents> table = new DbTable<TComponents>();
            TComponents prototype = new TComponents();
            prototype.LoadTable(table, "[CompatibleETO]={0}", DbConverter.FromStringNull(compatibleETO));
            return table;
        }

        public static DbTable<TComponents> LoadByProdApprov(DbNullable<string> prodApprov)
        {
            DbTable<TComponents> table = new DbTable<TComponents>();
            TComponents prototype = new TComponents();
            prototype.LoadTable(table, "[ProdApprov]={0}", DbConverter.FromStringNull(prodApprov));
            return table;
        }

        public static DbTable<TComponents> LoadByPhCheckInWareHouse(DbNullable<string> phCheckInWareHouse)
        {
            DbTable<TComponents> table = new DbTable<TComponents>();
            TComponents prototype = new TComponents();
            prototype.LoadTable(table, "[PhCheckInWareHouse]={0}", DbConverter.FromStringNull(phCheckInWareHouse));
            return table;
        }

        public static DbTable<TComponents> LoadByPVC(DbNullable<string> pVC)
        {
            DbTable<TComponents> table = new DbTable<TComponents>();
            TComponents prototype = new TComponents();
            prototype.LoadTable(table, "[PVC]={0}", DbConverter.FromStringNull(pVC));
            return table;
        }

        public static DbTable<TComponents> LoadByPhtalates(DbNullable<string> phtalates)
        {
            DbTable<TComponents> table = new DbTable<TComponents>();
            TComponents prototype = new TComponents();
            prototype.LoadTable(table, "[Phtalates]={0}", DbConverter.FromStringNull(phtalates));
            return table;
        }

        public static DbTable<TComponents> LoadByLatexInComp(DbNullable<string> latexInComp)
        {
            DbTable<TComponents> table = new DbTable<TComponents>();
            TComponents prototype = new TComponents();
            prototype.LoadTable(table, "[LatexInComp]={0}", DbConverter.FromStringNull(latexInComp));
            return table;
        }

        public static DbTable<TComponents> LoadByLatexInPack(DbNullable<string> latexInPack)
        {
            DbTable<TComponents> table = new DbTable<TComponents>();
            TComponents prototype = new TComponents();
            prototype.LoadTable(table, "[LatexInPack]={0}", DbConverter.FromStringNull(latexInPack));
            return table;
        }

        public static DbTable<TComponents> LoadByPyrogen(DbNullable<string> pyrogen)
        {
            DbTable<TComponents> table = new DbTable<TComponents>();
            TComponents prototype = new TComponents();
            prototype.LoadTable(table, "[Pyrogen]={0}", DbConverter.FromStringNull(pyrogen));
            return table;
        }

        public static DbTable<TComponents> LoadByPDMStatus(DbNullable<int> pDMStatus)
        {
            DbTable<TComponents> table = new DbTable<TComponents>();
            TComponents prototype = new TComponents();
            prototype.LoadTable(table, "[PDMStatus]={0}", DbConverter.FromIntNull(pDMStatus));
            return table;
        }

        public static DbTable<TComponents> LoadByPDMStatusPhotoID(DbNullable<int> pDMStatusPhotoID)
        {
            DbTable<TComponents> table = new DbTable<TComponents>();
            TComponents prototype = new TComponents();
            prototype.LoadTable(table, "[PDMStatusPhotoID]={0}", DbConverter.FromIntNull(pDMStatusPhotoID));
            return table;
        }

        public static DbTable<TComponents> LoadByKategorieKomponentu(DbNullable<string> kategorieKomponentu)
        {
            DbTable<TComponents> table = new DbTable<TComponents>();
            TComponents prototype = new TComponents();
            prototype.LoadTable(table, "[KategorieKomponentu]={0}", DbConverter.FromStringNull(kategorieKomponentu));
            return table;
        }

        public static DbTable<TComponents> LoadByKomponentKategorieID(DbNullable<int> komponentKategorieID)
        {
            DbTable<TComponents> table = new DbTable<TComponents>();
            TComponents prototype = new TComponents();
            prototype.LoadTable(table, "[KomponentKategorieID]={0}", DbConverter.FromIntNull(komponentKategorieID));
            return table;
        }

        public static DbTable<TComponents> LoadByNafotilKdoID(DbNullable<int> nafotilKdoID)
        {
            DbTable<TComponents> table = new DbTable<TComponents>();
            TComponents prototype = new TComponents();
            prototype.LoadTable(table, "[NafotilKdoID]={0}", DbConverter.FromIntNull(nafotilKdoID));
            return table;
        }

        public static DbTable<TComponents> LoadByDostupnostID(DbNullable<int> dostupnostID)
        {
            DbTable<TComponents> table = new DbTable<TComponents>();
            TComponents prototype = new TComponents();
            prototype.LoadTable(table, "[DostupnostID]={0}", DbConverter.FromIntNull(dostupnostID));
            return table;
        }

        public static DbTable<TComponents> LoadByQuestionStatus(DbNullable<int> questionStatus)
        {
            DbTable<TComponents> table = new DbTable<TComponents>();
            TComponents prototype = new TComponents();
            prototype.LoadTable(table, "[QuestionStatus]={0}", DbConverter.FromIntNull(questionStatus));
            return table;
        }

        public static DbTable<TComponents> LoadBy(string whereCondition, params object[] parameterValues)
        {
            DbTable<TComponents> table = new DbTable<TComponents>();
            TComponents prototype = new TComponents();
            prototype.LoadTable(table, whereCondition, parameterValues);
            return table;
        }
    }

    public class TCustomer: DbObject
    {
        private static DbSchema schema = null;

        public string CustomerNo
        {
            get { return DbConverter.ToString(this["CustomerNo"]); }
            set { this["CustomerNo"] = DbConverter.FromString(value); }
        }

        public DbNullable<string> CustomerName
        {
            get { return DbConverter.ToStringNull(this["CustomerName"]); }
            set { this["CustomerName"] = DbConverter.FromStringNull(value); }
        }

        protected override DbSchema GetSchema()
        {
            if (schema == null)
            {
                schema = new DbSchema("TCustomer");
                schema.Add("CustomerNo", typeof(string), "CustomerNo", false, true, false);
                schema.Add("CustomerName", typeof(string), "CustomerName", true);
            }

            return schema;
        }

        public override void LoadDefaultValues()
        {
            SqlCommand command = Session.CreateCommand();

            this["CustomerNo"] = DbConverter.DefaultString();

            this["CustomerName"] = DBNull.Value;
        }

        public static TCustomer Load(string customerNo)
        {
            TCustomer result = new TCustomer();
            result.LoadRecord(customerNo);
            return result;
        }

        public static TCustomer CachedLoad(string customerNo)
        {
            DbCache.TableKey key = new DbCache.TableKey("TCustomer");
            DbCache.CacheRecord record;
            key.Set(customerNo);
            if (DbCache.Contains(key))
            {
                record = DbCache.GetRecord(key);
                if (!record.IsValid())
                {
                    record.Value = Load(customerNo);
                    record.LastUpdate = DateTime.Now;
                    record.Valid = true;
                }
            }
            else
            {
                record = new DbCache.CacheRecord();
                record.Value = Load(customerNo);
                record.LastUpdate = DateTime.Now;
                record.Valid = true;
                DbCache.SetRecord(key, record);
            }
            return (TCustomer)record.Value;
        }

        public static TCustomer Create()
        {
            TCustomer result = new TCustomer();
            result.LoadDefaultValues();
            return result;
        }

        public static DbTable<TCustomer> LoadAll()
        {
            DbTable<TCustomer> table = new DbTable<TCustomer>();
            TCustomer prototype = new TCustomer();
            prototype.LoadTable(table);
            return table;
        }

        public static DbTable<TCustomer> LoadBy(string whereCondition, params object[] parameterValues)
        {
            DbTable<TCustomer> table = new DbTable<TCustomer>();
            TCustomer prototype = new TCustomer();
            prototype.LoadTable(table, whereCondition, parameterValues);
            return table;
        }
    }

    // TODO - odstranit mezery
    public class Customer_product_complaints: DbObject
    {
        private static DbSchema schema = null;

        public int id
        {
            get { return DbConverter.ToInt(this["id"]); }
            set { this["id"] = DbConverter.FromInt(value); }
        }

        public DbNullable<string> Notification
        {
            get { return DbConverter.ToStringNull(this["Notification"]); }
            set { this["Notification"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> Month
        {
            get { return DbConverter.ToStringNull(this["Month"]); }
            set { this["Month"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> Country
        {
            get { return DbConverter.ToStringNull(this["Country"]); }
            set { this["Country"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> Customer
        {
            get { return DbConverter.ToStringNull(this["Customer"]); }
            set { this["Customer"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> C_C
        {
            get { return DbConverter.ToStringNull(this["C C"]); }
            set { this["C C"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<DateTime> Created_on
        {
            get { return DbConverter.ToDateTimeNull(this["Created on"]); }
            set { this["Created on"] = DbConverter.FromDateTimeNull(value); }
        }

        public DbNullable<string> Manufact
        {
            get { return DbConverter.ToStringNull(this["Manufact"]); }
            set { this["Manufact"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> Plant
        {
            get { return DbConverter.ToStringNull(this["Plant"]); }
            set { this["Plant"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> Field9
        {
            get { return DbConverter.ToStringNull(this["Field9"]); }
            set { this["Field9"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> Material
        {
            get { return DbConverter.ToStringNull(this["Material"]); }
            set { this["Material"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> LOT
        {
            get { return DbConverter.ToStringNull(this["LOT"]); }
            set { this["LOT"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> Type
        {
            get { return DbConverter.ToStringNull(this["Type"]); }
            set { this["Type"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> Description_of_the_problem_by_CC
        {
            get { return DbConverter.ToStringNull(this["Description of the problem by CC"]); }
            set { this["Description of the problem by CC"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> Ka_defect
        {
            get { return DbConverter.ToStringNull(this["Ka_defect"]); }
            set { this["Ka_defect"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> Penalty_for_production
        {
            get { return DbConverter.ToStringNull(this["Penalty for production"]); }
            set { this["Penalty for production"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> Defect_type
        {
            get { return DbConverter.ToStringNull(this["Defect type"]); }
            set { this["Defect type"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> ZV_Notification
        {
            get { return DbConverter.ToStringNull(this["ZV Notification"]); }
            set { this["ZV Notification"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> Contact
        {
            get { return DbConverter.ToStringNull(this["Contact"]); }
            set { this["Contact"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> Quant
        {
            get { return DbConverter.ToStringNull(this["Quant"]); }
            set { this["Quant"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> Complaint_status
        {
            get { return DbConverter.ToStringNull(this["Complaint status"]); }
            set { this["Complaint status"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> CHF_comment
        {
            get { return DbConverter.ToStringNull(this["CHF comment"]); }
            set { this["CHF comment"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> Reference_notification_or_CAPA
        {
            get { return DbConverter.ToStringNull(this["Reference notification or CAPA"]); }
            set { this["Reference notification or CAPA"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> Samples
        {
            get { return DbConverter.ToStringNull(this["Samples"]); }
            set { this["Samples"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> R
        {
            get { return DbConverter.ToStringNull(this["R"]); }
            set { this["R"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> Related_concession
        {
            get { return DbConverter.ToStringNull(this["Related concession"]); }
            set { this["Related concession"] = DbConverter.FromStringNull(value); }
        }

        //TODO - Affected_component(s)
        public DbNullable<string> Affected_component
        {
            get { return DbConverter.ToStringNull(this["Affected component"]); }
            set { this["Affected component"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> Field30
        {
            get { return DbConverter.ToStringNull(this["Field30"]); }
            set { this["Field30"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<double> Field31
        {
            get { return DbConverter.ToDoubleNull(this["Field31"]); }
            set { this["Field31"] = DbConverter.FromDoubleNull(value); }
        }

        public DbNullable<string> Responsible_for_complaint
        {
            get { return DbConverter.ToStringNull(this["Responsible for complaint"]); }
            set { this["Responsible for complaint"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> Rok
        {
            get { return DbConverter.ToStringNull(this["Rok"]); }
            set { this["Rok"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> Týden
        {
            get { return DbConverter.ToStringNull(this["Týden"]); }
            set { this["Týden"] = DbConverter.FromStringNull(value); }
        }

        //TODO týden_rok remove -
        public DbNullable<string> týden_rok
        {
            get { return DbConverter.ToStringNull(this["týden_rok"]); }
            set { this["týden_rok"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> indikátor
        {
            get { return DbConverter.ToStringNull(this["indikátor"]); }
            set { this["indikátor"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> rokDK
        {
            get { return DbConverter.ToStringNull(this["rokDK"]); }
            set { this["rokDK"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<DateTime> SamplesDate
        {
            get { return DbConverter.ToDateTimeNull(this["SamplesDate"]); }
            set { this["SamplesDate"] = DbConverter.FromDateTimeNull(value); }
        }

        public DbNullable<DateTime> FinishDate
        {
            get { return DbConverter.ToDateTimeNull(this["FinishDate"]); }
            set { this["FinishDate"] = DbConverter.FromDateTimeNull(value); }
        }

        protected override DbSchema GetSchema()
        {
            if (schema == null)
            {
                schema = new DbSchema("Customer product complaints");
                schema.Add("id", typeof(int), "id", false, true, true);
                schema.Add("Notification", typeof(string), "Notification", true);
                schema.Add("Month", typeof(string), "Month", true);
                schema.Add("Country", typeof(string), "Country", true);
                schema.Add("Customer", typeof(string), "Customer", true);
                schema.Add("C C", typeof(string), "C C", true);
                schema.Add("Created on", typeof(DateTime), "Created on", true);
                schema.Add("Manufact", typeof(string), "Manufact", true);
                schema.Add("Plant", typeof(string), "Plant", true);
                schema.Add("Field9", typeof(string), "Field9", true);
                schema.Add("Material", typeof(string), "Material", true);
                schema.Add("LOT", typeof(string), "LOT", true);
                schema.Add("Type", typeof(string), "Type", true);
                schema.Add("Description of the problem by CC", typeof(string), "Description of the problem by CC", true);
                schema.Add("Ka-defect", typeof(string), "Ka-defect", true);
                schema.Add("Penalty for production", typeof(string), "Penalty for production", true);
                schema.Add("Defect type", typeof(string), "Defect type", true);
                schema.Add("ZV Notification", typeof(string), "ZV Notification", true);
                schema.Add("Contact", typeof(string), "Contact", true);
                schema.Add("Quant", typeof(string), "Quant", true);
                schema.Add("Complaint status", typeof(string), "Complaint status", true);
                schema.Add("CHF comment", typeof(string), "CHF comment", true);
                schema.Add("Reference notification or CAPA", typeof(string), "Reference notification or CAPA", true);
                schema.Add("Samples", typeof(string), "Samples", true);
                schema.Add("R", typeof(string), "R", true);
                schema.Add("Related concession", typeof(string), "Related concession", true);
                schema.Add("Affected component(s)", typeof(string), "Affected component(s)", true);
                schema.Add("Field30", typeof(string), "Field30", true);
                schema.Add("Field31", typeof(double), "Field31", true);
                schema.Add("Responsible for complaint", typeof(string), "Responsible for complaint", true);
                schema.Add("Rok", typeof(string), "Rok", true);
                schema.Add("Týden", typeof(string), "Týden", true);
                schema.Add("týden - rok", typeof(string), "týden - rok", true);
                schema.Add("indikátor", typeof(string), "indikátor", true);
                schema.Add("rokDK", typeof(string), "rokDK", true);
                schema.Add("SamplesDate", typeof(DateTime), "SamplesDate", true);
                schema.Add("FinishDate", typeof(DateTime), "FinishDate", true);
            }

            return schema;
        }

        public override void LoadDefaultValues()
        {
            SqlCommand command = Session.CreateCommand();

            this["id"] = DbConverter.DefaultInt();

            this["Notification"] = DBNull.Value;

            this["Month"] = DBNull.Value;

            this["Country"] = DBNull.Value;

            this["Customer"] = DBNull.Value;

            this["C C"] = DBNull.Value;

            this["Created on"] = DBNull.Value;

            this["Manufact"] = DBNull.Value;

            this["Plant"] = DBNull.Value;

            this["Field9"] = DBNull.Value;

            this["Material"] = DBNull.Value;

            this["LOT"] = DBNull.Value;

            this["Type"] = DBNull.Value;

            this["Description of the problem by CC"] = DBNull.Value;

            this["Ka-defect"] = DBNull.Value;

            this["Penalty for production"] = DBNull.Value;

            this["Defect type"] = DBNull.Value;

            this["ZV Notification"] = DBNull.Value;

            this["Contact"] = DBNull.Value;

            this["Quant"] = DBNull.Value;

            this["Complaint status"] = DBNull.Value;

            this["CHF comment"] = DBNull.Value;

            this["Reference notification or CAPA"] = DBNull.Value;

            this["Samples"] = DBNull.Value;

            this["R"] = DBNull.Value;

            this["Related concession"] = DBNull.Value;

            this["Affected component(s)"] = DBNull.Value;

            this["Field30"] = DBNull.Value;

            this["Field31"] = DBNull.Value;

            this["Responsible for complaint"] = DBNull.Value;

            this["Rok"] = DBNull.Value;

            this["Týden"] = DBNull.Value;

            this["týden - rok"] = DBNull.Value;

            this["indikátor"] = DBNull.Value;

            this["rokDK"] = DBNull.Value;

            this["SamplesDate"] = DBNull.Value;

            this["FinishDate"] = DBNull.Value;
        }

        // TODO Customer product complaints remove spaces
        public static Customer_product_complaints Load(int id)
        {
            Customer_product_complaints result = new Customer_product_complaints();
            result.LoadRecord(id);
            return result;
        }

        public static Customer_product_complaints CachedLoad(int id)
        {
            DbCache.TableKey key = new DbCache.TableKey("Customer product complaints");
            DbCache.CacheRecord record;
            key.Set(id);
            if (DbCache.Contains(key))
            {
                record = DbCache.GetRecord(key);
                if (!record.IsValid())
                {
                    record.Value = Load(id);
                    record.LastUpdate = DateTime.Now;
                    record.Valid = true;
                }
            }
            else
            {
                record = new DbCache.CacheRecord();
                record.Value = Load(id);
                record.LastUpdate = DateTime.Now;
                record.Valid = true;
                DbCache.SetRecord(key, record);
            }
            return (Customer_product_complaints)record.Value;
        }

        // TODO remove spaces
        public static Customer_product_complaints Create()
        {
            Customer_product_complaints result = new Customer_product_complaints();
            result.LoadDefaultValues();
            return result;
        }

        // TODO same as abovce
        public static DbTable<Customer_product_complaints> LoadAll()
        {
            DbTable<Customer_product_complaints> table = new DbTable<Customer_product_complaints>();
            Customer_product_complaints prototype = new Customer_product_complaints();
            prototype.LoadTable(table);
            return table;
        }

        // TODO same as above
        public static DbTable<Customer_product_complaints> LoadBy(string whereCondition, params object[] parameterValues)
        {
            DbTable<Customer_product_complaints> table = new DbTable<Customer_product_complaints>();
            Customer_product_complaints prototype = new Customer_product_complaints();
            prototype.LoadTable(table, whereCondition, parameterValues);
            return table;
        }
    }

    public class _SLimport: DbObject
    {
        private static DbSchema schema = null;

        public DbNullable<string> CisloSetu
        {
            get { return DbConverter.ToStringNull(this["CisloSetu"]); }
            set { this["CisloSetu"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> PoznamkaUloženiSetu
        {
            get { return DbConverter.ToStringNull(this["PoznamkaUloženiSetu"]); }
            set { this["PoznamkaUloženiSetu"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> DuleziteInformaceSetu
        {
            get { return DbConverter.ToStringNull(this["DuleziteInformaceSetu"]); }
            set { this["DuleziteInformaceSetu"] = DbConverter.FromStringNull(value); }
        }

        protected override DbSchema GetSchema()
        {
            if (schema == null)
            {
                schema = new DbSchema("_SLimport");
                schema.Add("CisloSetu", typeof(string), "CisloSetu", true);
                schema.Add("PoznamkaUloženiSetu", typeof(string), "PoznamkaUloženiSetu", true);
                schema.Add("DuleziteInformaceSetu", typeof(string), "DuleziteInformaceSetu", true);
            }

            return schema;
        }

        public override void LoadDefaultValues()
        {
            SqlCommand command = Session.CreateCommand();

            this["CisloSetu"] = DBNull.Value;

            this["PoznamkaUloženiSetu"] = DBNull.Value;

            this["DuleziteInformaceSetu"] = DBNull.Value;
        }

        public static _SLimport Load()
        {
            _SLimport result = new _SLimport();
            result.LoadRecord();
            return result;
        }

        public static _SLimport CachedLoad()
        {
            DbCache.TableKey key = new DbCache.TableKey("_SLimport");
            DbCache.CacheRecord record;
            key.Set();
            if (DbCache.Contains(key))
            {
                record = DbCache.GetRecord(key);
                if (!record.IsValid())
                {
                    record.Value = Load();
                    record.LastUpdate = DateTime.Now;
                    record.Valid = true;
                }
            }
            else
            {
                record = new DbCache.CacheRecord();
                record.Value = Load();
                record.LastUpdate = DateTime.Now;
                record.Valid = true;
                DbCache.SetRecord(key, record);
            }
            return (_SLimport)record.Value;
        }

        public static _SLimport Create()
        {
            _SLimport result = new _SLimport();
            result.LoadDefaultValues();
            return result;
        }

        public static DbTable<_SLimport> LoadAll()
        {
            DbTable<_SLimport> table = new DbTable<_SLimport>();
            _SLimport prototype = new _SLimport();
            prototype.LoadTable(table);
            return table;
        }

        public static DbTable<_SLimport> LoadBy(string whereCondition, params object[] parameterValues)
        {
            DbTable<_SLimport> table = new DbTable<_SLimport>();
            _SLimport prototype = new _SLimport();
            prototype.LoadTable(table, whereCondition, parameterValues);
            return table;
        }
    }

    public class _SLimport2: DbObject
    {
        private static DbSchema schema = null;

        public DbNullable<string> CisloSetu
        {
            get { return DbConverter.ToStringNull(this["CisloSetu"]); }
            set { this["CisloSetu"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> PoznamkaUloženiSetu
        {
            get { return DbConverter.ToStringNull(this["PoznamkaUloženiSetu"]); }
            set { this["PoznamkaUloženiSetu"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> DuleziteInformaceSetu
        {
            get { return DbConverter.ToStringNull(this["DuleziteInformaceSetu"]); }
            set { this["DuleziteInformaceSetu"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<int> ID
        {
            get { return DbConverter.ToIntNull(this["ID"]); }
            set { this["ID"] = DbConverter.FromIntNull(value); }
        }

        protected override DbSchema GetSchema()
        {
            if (schema == null)
            {
                schema = new DbSchema("_SLimport2");
                schema.Add("CisloSetu", typeof(string), "CisloSetu", true);
                schema.Add("PoznamkaUloženiSetu", typeof(string), "PoznamkaUloženiSetu", true);
                schema.Add("DuleziteInformaceSetu", typeof(string), "DuleziteInformaceSetu", true);
                schema.Add("ID", typeof(int), "ID", true);
            }

            return schema;
        }

        public override void LoadDefaultValues()
        {
            SqlCommand command = Session.CreateCommand();

            this["CisloSetu"] = DBNull.Value;

            this["PoznamkaUloženiSetu"] = DBNull.Value;

            this["DuleziteInformaceSetu"] = DBNull.Value;

            this["ID"] = DBNull.Value;
        }

        public static _SLimport2 Load()
        {
            _SLimport2 result = new _SLimport2();
            result.LoadRecord();
            return result;
        }

        public static _SLimport2 CachedLoad()
        {
            DbCache.TableKey key = new DbCache.TableKey("_SLimport2");
            DbCache.CacheRecord record;
            key.Set();
            if (DbCache.Contains(key))
            {
                record = DbCache.GetRecord(key);
                if (!record.IsValid())
                {
                    record.Value = Load();
                    record.LastUpdate = DateTime.Now;
                    record.Valid = true;
                }
            }
            else
            {
                record = new DbCache.CacheRecord();
                record.Value = Load();
                record.LastUpdate = DateTime.Now;
                record.Valid = true;
                DbCache.SetRecord(key, record);
            }
            return (_SLimport2)record.Value;
        }

        public static _SLimport2 Create()
        {
            _SLimport2 result = new _SLimport2();
            result.LoadDefaultValues();
            return result;
        }

        public static DbTable<_SLimport2> LoadAll()
        {
            DbTable<_SLimport2> table = new DbTable<_SLimport2>();
            _SLimport2 prototype = new _SLimport2();
            prototype.LoadTable(table);
            return table;
        }

        public static DbTable<_SLimport2> LoadBy(string whereCondition, params object[] parameterValues)
        {
            DbTable<_SLimport2> table = new DbTable<_SLimport2>();
            _SLimport2 prototype = new _SLimport2();
            prototype.LoadTable(table, whereCondition, parameterValues);
            return table;
        }
    }

    public class TBatchImp: DbObject
    {
        private static DbSchema schema = null;

        public int ID
        {
            get { return DbConverter.ToInt(this["ID"]); }
            set { this["ID"] = DbConverter.FromInt(value); }
        }

        public DbNullable<string> OrderNumber
        {
            get { return DbConverter.ToStringNull(this["OrderNumber"]); }
            set { this["OrderNumber"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> MaterialNumber
        {
            get { return DbConverter.ToStringNull(this["MaterialNumber"]); }
            set { this["MaterialNumber"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<int> OrderQuantity
        {
            get { return DbConverter.ToIntNull(this["OrderQuantity"]); }
            set { this["OrderQuantity"] = DbConverter.FromIntNull(value); }
        }

        public DbNullable<string> BatchNumber
        {
            get { return DbConverter.ToStringNull(this["BatchNumber"]); }
            set { this["BatchNumber"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> ProductLine
        {
            get { return DbConverter.ToStringNull(this["ProductLine"]); }
            set { this["ProductLine"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> Shift
        {
            get { return DbConverter.ToStringNull(this["Shift"]); }
            set { this["Shift"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> ComponentCode
        {
            get { return DbConverter.ToStringNull(this["ComponentCode"]); }
            set { this["ComponentCode"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<decimal> PcPerSet
        {
            get { return DbConverter.ToDecimalNull(this["PcPerSet"]); }
            set { this["PcPerSet"] = DbConverter.FromDecimalNull(value); }
        }

        public DbNullable<string> CompbatchNumber
        {
            get { return DbConverter.ToStringNull(this["CompbatchNumber"]); }
            set { this["CompbatchNumber"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> Expiration
        {
            get { return DbConverter.ToStringNull(this["Expiration"]); }
            set { this["Expiration"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> Customer
        {
            get { return DbConverter.ToStringNull(this["Customer"]); }
            set { this["Customer"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> Weight
        {
            get { return DbConverter.ToStringNull(this["Weight"]); }
            set { this["Weight"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> Box
        {
            get { return DbConverter.ToStringNull(this["Box"]); }
            set { this["Box"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> Mistakes
        {
            get { return DbConverter.ToStringNull(this["Mistakes"]); }
            set { this["Mistakes"] = DbConverter.FromStringNull(value); }
        }

        protected override DbSchema GetSchema()
        {
            if (schema == null)
            {
                schema = new DbSchema("TBatchImp");
                schema.Add("ID", typeof(int), "ID", false, true, true);
                schema.Add("OrderNumber", typeof(string), "OrderNumber", true);
                schema.Add("MaterialNumber", typeof(string), "MaterialNumber", true);
                schema.Add("OrderQuantity", typeof(int), "OrderQuantity", true);
                schema.Add("BatchNumber", typeof(string), "BatchNumber", true);
                schema.Add("ProductLine", typeof(string), "ProductLine", true);
                schema.Add("Shift", typeof(string), "Shift", true);
                schema.Add("ComponentCode", typeof(string), "ComponentCode", true);
                schema.Add("PcPerSet", typeof(decimal), "PcPerSet", true);
                schema.Add("CompbatchNumber", typeof(string), "CompbatchNumber", true);
                schema.Add("Expiration", typeof(string), "Expiration", true);
                schema.Add("Customer", typeof(string), "Customer", true);
                schema.Add("Weight", typeof(string), "Weight", true);
                schema.Add("Box", typeof(string), "Box", true);
                schema.Add("Mistakes", typeof(string), "Mistakes", true);
            }

            return schema;
        }

        public override void LoadDefaultValues()
        {
            SqlCommand command = Session.CreateCommand();

            this["ID"] = DbConverter.DefaultInt();

            this["OrderNumber"] = DBNull.Value;

            this["MaterialNumber"] = DBNull.Value;

            this["OrderQuantity"] = DBNull.Value;

            this["BatchNumber"] = DBNull.Value;

            this["ProductLine"] = DBNull.Value;

            this["Shift"] = DBNull.Value;

            this["ComponentCode"] = DBNull.Value;

            this["PcPerSet"] = DBNull.Value;

            this["CompbatchNumber"] = DBNull.Value;

            this["Expiration"] = DBNull.Value;

            this["Customer"] = DBNull.Value;

            this["Weight"] = DBNull.Value;

            this["Box"] = DBNull.Value;

            this["Mistakes"] = DBNull.Value;
        }

        public static TBatchImp Load(int iD)
        {
            TBatchImp result = new TBatchImp();
            result.LoadRecord(iD);
            return result;
        }

        public static TBatchImp CachedLoad(int iD)
        {
            DbCache.TableKey key = new DbCache.TableKey("TBatchImp");
            DbCache.CacheRecord record;
            key.Set(iD);
            if (DbCache.Contains(key))
            {
                record = DbCache.GetRecord(key);
                if (!record.IsValid())
                {
                    record.Value = Load(iD);
                    record.LastUpdate = DateTime.Now;
                    record.Valid = true;
                }
            }
            else
            {
                record = new DbCache.CacheRecord();
                record.Value = Load(iD);
                record.LastUpdate = DateTime.Now;
                record.Valid = true;
                DbCache.SetRecord(key, record);
            }
            return (TBatchImp)record.Value;
        }

        public static TBatchImp Create()
        {
            TBatchImp result = new TBatchImp();
            result.LoadDefaultValues();
            return result;
        }

        public static DbTable<TBatchImp> LoadAll()
        {
            DbTable<TBatchImp> table = new DbTable<TBatchImp>();
            TBatchImp prototype = new TBatchImp();
            prototype.LoadTable(table);
            return table;
        }

        public static DbTable<TBatchImp> LoadBy(string whereCondition, params object[] parameterValues)
        {
            DbTable<TBatchImp> table = new DbTable<TBatchImp>();
            TBatchImp prototype = new TBatchImp();
            prototype.LoadTable(table, whereCondition, parameterValues);
            return table;
        }
    }

    public class CompTemp: DbObject
    {
        private static DbSchema schema = null;

        public DbNullable<string> Code
        {
            get { return DbConverter.ToStringNull(this["Code"]); }
            set { this["Code"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> VAR
        {
            get { return DbConverter.ToStringNull(this["VAR"]); }
            set { this["VAR"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> VAR2
        {
            get { return DbConverter.ToStringNull(this["VAR2"]); }
            set { this["VAR2"] = DbConverter.FromStringNull(value); }
        }

        protected override DbSchema GetSchema()
        {
            if (schema == null)
            {
                schema = new DbSchema("CompTemp");
                schema.Add("Code", typeof(string), "Code", true);
                schema.Add("VAR", typeof(string), "VAR", true);
                schema.Add("VAR2", typeof(string), "VAR2", true);
            }

            return schema;
        }

        public override void LoadDefaultValues()
        {
            SqlCommand command = Session.CreateCommand();

            this["Code"] = DBNull.Value;

            this["VAR"] = DBNull.Value;

            this["VAR2"] = DBNull.Value;
        }

        public static CompTemp Load()
        {
            CompTemp result = new CompTemp();
            result.LoadRecord();
            return result;
        }

        public static CompTemp CachedLoad()
        {
            DbCache.TableKey key = new DbCache.TableKey("CompTemp");
            DbCache.CacheRecord record;
            key.Set();
            if (DbCache.Contains(key))
            {
                record = DbCache.GetRecord(key);
                if (!record.IsValid())
                {
                    record.Value = Load();
                    record.LastUpdate = DateTime.Now;
                    record.Valid = true;
                }
            }
            else
            {
                record = new DbCache.CacheRecord();
                record.Value = Load();
                record.LastUpdate = DateTime.Now;
                record.Valid = true;
                DbCache.SetRecord(key, record);
            }
            return (CompTemp)record.Value;
        }

        public static CompTemp Create()
        {
            CompTemp result = new CompTemp();
            result.LoadDefaultValues();
            return result;
        }

        public static DbTable<CompTemp> LoadAll()
        {
            DbTable<CompTemp> table = new DbTable<CompTemp>();
            CompTemp prototype = new CompTemp();
            prototype.LoadTable(table);
            return table;
        }

        public static DbTable<CompTemp> LoadBy(string whereCondition, params object[] parameterValues)
        {
            DbTable<CompTemp> table = new DbTable<CompTemp>();
            CompTemp prototype = new CompTemp();
            prototype.LoadTable(table, whereCondition, parameterValues);
            return table;
        }
    }

    public class TCoordinator: DbObject
    {
        private static DbSchema schema = null;

        public string CoordCode
        {
            get { return DbConverter.ToString(this["CoordCode"]); }
            set { this["CoordCode"] = DbConverter.FromString(value); }
        }

        public DbNullable<string> CCName
        {
            get { return DbConverter.ToStringNull(this["CCName"]); }
            set { this["CCName"] = DbConverter.FromStringNull(value); }
        }

        protected override DbSchema GetSchema()
        {
            if (schema == null)
            {
                schema = new DbSchema("TCoordinator");
                schema.Add("CoordCode", typeof(string), "CoordCode", false, true, false);
                schema.Add("CCName", typeof(string), "CCName", true);
            }

            return schema;
        }

        public override void LoadDefaultValues()
        {
            SqlCommand command = Session.CreateCommand();

            this["CoordCode"] = DbConverter.DefaultString();

            this["CCName"] = DBNull.Value;
        }

        public static TCoordinator Load(string coordCode)
        {
            TCoordinator result = new TCoordinator();
            result.LoadRecord(coordCode);
            return result;
        }

        public static TCoordinator CachedLoad(string coordCode)
        {
            DbCache.TableKey key = new DbCache.TableKey("TCoordinator");
            DbCache.CacheRecord record;
            key.Set(coordCode);
            if (DbCache.Contains(key))
            {
                record = DbCache.GetRecord(key);
                if (!record.IsValid())
                {
                    record.Value = Load(coordCode);
                    record.LastUpdate = DateTime.Now;
                    record.Valid = true;
                }
            }
            else
            {
                record = new DbCache.CacheRecord();
                record.Value = Load(coordCode);
                record.LastUpdate = DateTime.Now;
                record.Valid = true;
                DbCache.SetRecord(key, record);
            }
            return (TCoordinator)record.Value;
        }

        public static TCoordinator Create()
        {
            TCoordinator result = new TCoordinator();
            result.LoadDefaultValues();
            return result;
        }

        public static DbTable<TCoordinator> LoadAll()
        {
            DbTable<TCoordinator> table = new DbTable<TCoordinator>();
            TCoordinator prototype = new TCoordinator();
            prototype.LoadTable(table);
            return table;
        }

        public static DbTable<TCoordinator> LoadBy(string whereCondition, params object[] parameterValues)
        {
            DbTable<TCoordinator> table = new DbTable<TCoordinator>();
            TCoordinator prototype = new TCoordinator();
            prototype.LoadTable(table, whereCondition, parameterValues);
            return table;
        }
    }

    public class ImportComp: DbObject
    {
        private static DbSchema schema = null;

        public int ID
        {
            get { return DbConverter.ToInt(this["ID"]); }
            set { this["ID"] = DbConverter.FromInt(value); }
        }

        public DbNullable<string> MHC_Code
        {
            get { return DbConverter.ToStringNull(this["MHC Code"]); }
            set { this["MHC Code"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> Vendor_code
        {
            get { return DbConverter.ToStringNull(this["Vendor code"]); }
            set { this["Vendor code"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> Description
        {
            get { return DbConverter.ToStringNull(this["Description"]); }
            set { this["Description"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> Supplier
        {
            get { return DbConverter.ToStringNull(this["Supplier"]); }
            set { this["Supplier"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> manufacturer
        {
            get { return DbConverter.ToStringNull(this["manufacturer"]); }
            set { this["manufacturer"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> Responsible
        {
            get { return DbConverter.ToStringNull(this["Responsible"]); }
            set { this["Responsible"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> Issue
        {
            get { return DbConverter.ToStringNull(this["Issue"]); }
            set { this["Issue"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> MDD_Class
        {
            get { return DbConverter.ToStringNull(this["MDD Class"]); }
            set { this["MDD Class"] = DbConverter.FromStringNull(value); }
        }

        // TODO CE_mark_(CE_certificate/Declaration_of_conformity)
        public DbNullable<string> CE_mark_CE_certificate_Declaration_of_conformity
        {
            get { return DbConverter.ToStringNull(this["CE_mark_CE_certificate_Declaration_of_conformity"]); }
            set { this["CE_mark_CE_certificate_Declaration_of_conformity"] = DbConverter.FromStringNull(value); }
        }

        // TODO Expiry/Issue_date_of_CE_certificate_/_Declaration_of_conformity
        public DbNullable<DateTime> Expiry_Issue_date_of_CE_certificate__Declaration_of_conformity
        {
            get { return DbConverter.ToDateTimeNull(this["Expiry_Issue_date_of_CE_certificate__Declaration_of_conformity"]); }
            set { this["Expiry_Issue_date_of_CE_certificate__Declaration_of_conformity"] = DbConverter.FromDateTimeNull(value); }
        }

        public DbNullable<string> Compatibility_with_ETO
        {
            get { return DbConverter.ToStringNull(this["Compatibility with ETO"]); }
            set { this["Compatibility with ETO"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> ProductioNo_approval
        {
            get { return DbConverter.ToStringNull(this["ProductioNo approval"]); }
            set { this["ProductioNo approval"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> Physical_check_in_warehouse
        {
            get { return DbConverter.ToStringNull(this["Physical check in warehouse"]); }
            set { this["Physical check in warehouse"] = DbConverter.FromStringNull(value); }
        }

        //TODO Comments_(residuals,_reference_components)
        public DbNullable<string> Comments_residuals_reference_components
        {
            get { return DbConverter.ToStringNull(this["Comments_residuals_reference_components"]); }
            set { this["Comments_residuals_reference_components"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> Questionnaire
        {
            get { return DbConverter.ToStringNull(this["Questionnaire"]); }
            set { this["Questionnaire"] = DbConverter.FromStringNull(value); }
        }

        // TODO Year_-_week
        public DbNullable<string> Year_week
        {
            get { return DbConverter.ToStringNull(this["Year_week"]); }
            set { this["Year_week"] = DbConverter.FromStringNull(value); }
        }

        // TODO Set-up_date
        public DbNullable<string> Set_up_date
        {
            get { return DbConverter.ToStringNull(this["Set_up_date"]); }
            set { this["Set_up_date"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<DateTime> Approval_date
        {
            get { return DbConverter.ToDateTimeNull(this["Approval date"]); }
            set { this["Approval date"] = DbConverter.FromDateTimeNull(value); }
        }

        public DbNullable<string> Tracking_date
        {
            get { return DbConverter.ToStringNull(this["Tracking date"]); }
            set { this["Tracking date"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> Material_composition
        {
            get { return DbConverter.ToStringNull(this["Material composition"]); }
            set { this["Material composition"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> PVC
        {
            get { return DbConverter.ToStringNull(this["PVC"]); }
            set { this["PVC"] = DbConverter.FromStringNull(value); }
        }
        
        // TODO remove ()
        public DbNullable<string> Phtalates_DEHP
        {
            get { return DbConverter.ToStringNull(this["Phtalates DEHP"]); }
            set { this["Phtalates DEHP"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> Contains_latex_in_packaging
        {
            get { return DbConverter.ToStringNull(this["Contains latex in packaging"]); }
            set { this["Contains latex in packaging"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> Pyrogen
        {
            get { return DbConverter.ToStringNull(this["Pyrogen"]); }
            set { this["Pyrogen"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> Storage_temperature
        {
            get { return DbConverter.ToStringNull(this["Storage temperature"]); }
            set { this["Storage temperature"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> Other_Storage_conditions
        {
            get { return DbConverter.ToStringNull(this["Other Storage conditions"]); }
            set { this["Other Storage conditions"] = DbConverter.FromStringNull(value); }
        }

        // TODO Maximal_sterilization_vacuum_(mbarr_Absolute)
        public DbNullable<string> Maximal_sterilization_vacuum_mbarr_Absolute
        {
            get { return DbConverter.ToStringNull(this["Maximal_sterilization_vacuum_mbarr_Absolute"]); }
            set { this["Maximal_sterilization_vacuum_mbarr_Absolute"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> PDM_status
        {
            get { return DbConverter.ToStringNull(this["PDM status"]); }
            set { this["PDM status"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> Field29
        {
            get { return DbConverter.ToStringNull(this["Field29"]); }
            set { this["Field29"] = DbConverter.FromStringNull(value); }
        }

        // TODO time_needed_for_approval_(minutes)
        public DbNullable<string> time_needed_for_approval_minutes
        {
            get { return DbConverter.ToStringNull(this["time_needed_for_approval_minutes"]); }
            set { this["time_needed_for_approval_minutes"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> intended_use
        {
            get { return DbConverter.ToStringNull(this["intended use"]); }
            set { this["intended use"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> Contains_latex_in_component
        {
            get { return DbConverter.ToStringNull(this["Contains latex in component"]); }
            set { this["Contains latex in component"] = DbConverter.FromStringNull(value); }
        }

        protected override DbSchema GetSchema()
        {
            if (schema == null)
            {
                schema = new DbSchema("ImportComp");
                schema.Add("ID", typeof(int), "ID", false);
                schema.Add("MHC Code", typeof(string), "MHC Code", true);
                schema.Add("Vendor code", typeof(string), "Vendor code", true);
                schema.Add("Description", typeof(string), "Description", true);
                schema.Add("Supplier", typeof(string), "Supplier", true);
                schema.Add("manufacturer", typeof(string), "manufacturer", true);
                schema.Add("Responsible", typeof(string), "Responsible", true);
                schema.Add("Issue", typeof(string), "Issue", true);
                schema.Add("MDD Class", typeof(string), "MDD Class", true);
                schema.Add("CE mark (CE certificate/Declaration of conformity)", typeof(string), "CE mark (CE certificate/Declaration of conformity)", true);
                schema.Add("Expiry/Issue date of CE certificate / Declaration of conformity", typeof(DateTime), "Expiry/Issue date of CE certificate / Declaration of conformity", true);
                schema.Add("Compatibility with ETO", typeof(string), "Compatibility with ETO", true);
                schema.Add("ProductioNo approval", typeof(string), "ProductioNo approval", true);
                schema.Add("Physical check in warehouse", typeof(string), "Physical check in warehouse", true);
                schema.Add("Comments (residuals, reference components)", typeof(string), "Comments (residuals, reference components)", true);
                schema.Add("Questionnaire", typeof(string), "Questionnaire", true);
                schema.Add("Year - week", typeof(string), "Year - week", true);
                schema.Add("Set-up date", typeof(string), "Set-up date", true);
                schema.Add("Approval date", typeof(DateTime), "Approval date", true);
                schema.Add("Tracking date", typeof(string), "Tracking date", true);
                schema.Add("Material composition", typeof(string), "Material composition", true);
                schema.Add("PVC", typeof(string), "PVC", true);
                schema.Add("Phtalates (DEHP)", typeof(string), "Phtalates (DEHP)", true);
                schema.Add("Contains latex in packaging", typeof(string), "Contains latex in packaging", true);
                schema.Add("Pyrogen", typeof(string), "Pyrogen", true);
                schema.Add("Storage temperature", typeof(string), "Storage temperature", true);
                schema.Add("Other Storage conditions", typeof(string), "Other Storage conditions", true);
                schema.Add("Maximal sterilization vacuum (mbarr Absolute)", typeof(string), "Maximal sterilization vacuum (mbarr Absolute)", true);
                schema.Add("PDM status", typeof(string), "PDM status", true);
                schema.Add("Field29", typeof(string), "Field29", true);
                schema.Add("time needed for approval (minutes)", typeof(string), "time needed for approval (minutes)", true);
                schema.Add("intended use", typeof(string), "intended use", true);
                schema.Add("Contains latex in component", typeof(string), "Contains latex in component", true);
            }

            return schema;
        }

        public override void LoadDefaultValues()
        {
            SqlCommand command = Session.CreateCommand();

            this["ID"] = DbConverter.DefaultInt();

            this["MHC Code"] = DBNull.Value;

            this["Vendor code"] = DBNull.Value;

            this["Description"] = DBNull.Value;

            this["Supplier"] = DBNull.Value;

            this["manufacturer"] = DBNull.Value;

            this["Responsible"] = DBNull.Value;

            this["Issue"] = DBNull.Value;

            this["MDD Class"] = DBNull.Value;

            this["CE mark (CE certificate/Declaration of conformity)"] = DBNull.Value;

            this["Expiry/Issue date of CE certificate / Declaration of conformity"] = DBNull.Value;

            this["Compatibility with ETO"] = DBNull.Value;

            this["ProductioNo approval"] = DBNull.Value;

            this["Physical check in warehouse"] = DBNull.Value;

            this["Comments (residuals, reference components)"] = DBNull.Value;

            this["Questionnaire"] = DBNull.Value;

            this["Year - week"] = DBNull.Value;

            this["Set-up date"] = DBNull.Value;

            this["Approval date"] = DBNull.Value;

            this["Tracking date"] = DBNull.Value;

            this["Material composition"] = DBNull.Value;

            this["PVC"] = DBNull.Value;

            this["Phtalates (DEHP)"] = DBNull.Value;

            this["Contains latex in packaging"] = DBNull.Value;

            this["Pyrogen"] = DBNull.Value;

            this["Storage temperature"] = DBNull.Value;

            this["Other Storage conditions"] = DBNull.Value;

            this["Maximal sterilization vacuum (mbarr Absolute)"] = DBNull.Value;

            this["PDM status"] = DBNull.Value;

            this["Field29"] = DBNull.Value;

            this["time needed for approval (minutes)"] = DBNull.Value;

            this["intended use"] = DBNull.Value;

            this["Contains latex in component"] = DBNull.Value;
        }

        public static ImportComp Load()
        {
            ImportComp result = new ImportComp();
            result.LoadRecord();
            return result;
        }

        public static ImportComp CachedLoad()
        {
            DbCache.TableKey key = new DbCache.TableKey("ImportComp");
            DbCache.CacheRecord record;
            key.Set();
            if (DbCache.Contains(key))
            {
                record = DbCache.GetRecord(key);
                if (!record.IsValid())
                {
                    record.Value = Load();
                    record.LastUpdate = DateTime.Now;
                    record.Valid = true;
                }
            }
            else
            {
                record = new DbCache.CacheRecord();
                record.Value = Load();
                record.LastUpdate = DateTime.Now;
                record.Valid = true;
                DbCache.SetRecord(key, record);
            }
            return (ImportComp)record.Value;
        }

        public static ImportComp Create()
        {
            ImportComp result = new ImportComp();
            result.LoadDefaultValues();
            return result;
        }

        public static DbTable<ImportComp> LoadAll()
        {
            DbTable<ImportComp> table = new DbTable<ImportComp>();
            ImportComp prototype = new ImportComp();
            prototype.LoadTable(table);
            return table;
        }

        public static DbTable<ImportComp> LoadBy(string whereCondition, params object[] parameterValues)
        {
            DbTable<ImportComp> table = new DbTable<ImportComp>();
            ImportComp prototype = new ImportComp();
            prototype.LoadTable(table, whereCondition, parameterValues);
            return table;
        }
    }

    public class TPrikazVyskladneni: DbObject
    {
        private static DbSchema schema = null;

        public int IDPrikazVyskladneni
        {
            get { return DbConverter.ToInt(this["IDPrikazVyskladneni"]); }
            set { this["IDPrikazVyskladneni"] = DbConverter.FromInt(value); }
        }

        public DbNullable<string> CisloSetu
        {
            get { return DbConverter.ToStringNull(this["CisloSetu"]); }
            set { this["CisloSetu"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<DateTime> Created
        {
            get { return DbConverter.ToDateTimeNull(this["Created"]); }
            set { this["Created"] = DbConverter.FromDateTimeNull(value); }
        }

        public DbNullable<int> CreatedBy
        {
            get { return DbConverter.ToIntNull(this["CreatedBy"]); }
            set { this["CreatedBy"] = DbConverter.FromIntNull(value); }
        }

        public DbNullable<int> Zeme
        {
            get { return DbConverter.ToIntNull(this["Zeme"]); }
            set { this["Zeme"] = DbConverter.FromIntNull(value); }
        }

        public DbNullable<int> SampleList
        {
            get { return DbConverter.ToIntNull(this["SampleList"]); }
            set { this["SampleList"] = DbConverter.FromIntNull(value); }
        }

        public DbNullable<decimal> Weight
        {
            get { return DbConverter.ToDecimalNull(this["Weight"]); }
            set { this["Weight"] = DbConverter.FromDecimalNull(value); }
        }

        protected override DbSchema GetSchema()
        {
            if (schema == null)
            {
                schema = new DbSchema("TPrikazVyskladneni");
                schema.Add("IDPrikazVyskladneni", typeof(int), "IDPrikazVyskladneni", false, true, true);
                schema.Add("CisloSetu", typeof(string), "CisloSetu", true);
                schema.Add("Created", typeof(DateTime), "Created", true);
                schema.Add("CreatedBy", typeof(int), "CreatedBy", true);
                schema.Add("Zeme", typeof(int), "Zeme", true);
                schema.Add("SampleList", typeof(int), "SampleList", true);
                schema.Add("Weight", typeof(decimal), "Weight", true);
            }

            return schema;
        }

        public override void LoadDefaultValues()
        {
            SqlCommand command = Session.CreateCommand();

            this["IDPrikazVyskladneni"] = DbConverter.DefaultInt();

            this["CisloSetu"] = DBNull.Value;

            command.CommandText = "SELECT (getdate())";
            this["Created"] = command.ExecuteScalar();

            this["CreatedBy"] = DBNull.Value;

            this["Zeme"] = DBNull.Value;

            this["SampleList"] = DBNull.Value;

            this["Weight"] = DBNull.Value;
        }

        public static TPrikazVyskladneni Load(int iDPrikazVyskladneni)
        {
            TPrikazVyskladneni result = new TPrikazVyskladneni();
            result.LoadRecord(iDPrikazVyskladneni);
            return result;
        }

        public static TPrikazVyskladneni CachedLoad(int iDPrikazVyskladneni)
        {
            DbCache.TableKey key = new DbCache.TableKey("TPrikazVyskladneni");
            DbCache.CacheRecord record;
            key.Set(iDPrikazVyskladneni);
            if (DbCache.Contains(key))
            {
                record = DbCache.GetRecord(key);
                if (!record.IsValid())
                {
                    record.Value = Load(iDPrikazVyskladneni);
                    record.LastUpdate = DateTime.Now;
                    record.Valid = true;
                }
            }
            else
            {
                record = new DbCache.CacheRecord();
                record.Value = Load(iDPrikazVyskladneni);
                record.LastUpdate = DateTime.Now;
                record.Valid = true;
                DbCache.SetRecord(key, record);
            }
            return (TPrikazVyskladneni)record.Value;
        }

        public static TPrikazVyskladneni Create()
        {
            TPrikazVyskladneni result = new TPrikazVyskladneni();
            result.LoadDefaultValues();
            return result;
        }

        public static DbTable<TPrikazVyskladneni> LoadAll()
        {
            DbTable<TPrikazVyskladneni> table = new DbTable<TPrikazVyskladneni>();
            TPrikazVyskladneni prototype = new TPrikazVyskladneni();
            prototype.LoadTable(table);
            return table;
        }

        public static DbTable<TPrikazVyskladneni> LoadByCreatedBy(DbNullable<int> createdBy)
        {
            DbTable<TPrikazVyskladneni> table = new DbTable<TPrikazVyskladneni>();
            TPrikazVyskladneni prototype = new TPrikazVyskladneni();
            prototype.LoadTable(table, "[CreatedBy]={0}", DbConverter.FromIntNull(createdBy));
            return table;
        }

        public static DbTable<TPrikazVyskladneni> LoadByZeme(DbNullable<int> zeme)
        {
            DbTable<TPrikazVyskladneni> table = new DbTable<TPrikazVyskladneni>();
            TPrikazVyskladneni prototype = new TPrikazVyskladneni();
            prototype.LoadTable(table, "[Zeme]={0}", DbConverter.FromIntNull(zeme));
            return table;
        }

        public static DbTable<TPrikazVyskladneni> LoadBySampleList(DbNullable<int> sampleList)
        {
            DbTable<TPrikazVyskladneni> table = new DbTable<TPrikazVyskladneni>();
            TPrikazVyskladneni prototype = new TPrikazVyskladneni();
            prototype.LoadTable(table, "[SampleList]={0}", DbConverter.FromIntNull(sampleList));
            return table;
        }

        public static DbTable<TPrikazVyskladneni> LoadBy(string whereCondition, params object[] parameterValues)
        {
            DbTable<TPrikazVyskladneni> table = new DbTable<TPrikazVyskladneni>();
            TPrikazVyskladneni prototype = new TPrikazVyskladneni();
            prototype.LoadTable(table, whereCondition, parameterValues);
            return table;
        }
    }

    public class TMovementTypes: DbObject
    {
        private static DbSchema schema = null;

        public int MovementTypeID
        {
            get { return DbConverter.ToInt(this["MovementTypeID"]); }
            set { this["MovementTypeID"] = DbConverter.FromInt(value); }
        }

        public string MovementTypeName
        {
            get { return DbConverter.ToString(this["MovementTypeName"]); }
            set { this["MovementTypeName"] = DbConverter.FromString(value); }
        }

        public string MovementCode
        {
            get { return DbConverter.ToString(this["MovementCode"]); }
            set { this["MovementCode"] = DbConverter.FromString(value); }
        }

        protected override DbSchema GetSchema()
        {
            if (schema == null)
            {
                schema = new DbSchema("TMovementTypes");
                schema.Add("MovementTypeID", typeof(int), "MovementTypeID", false, true, true);
                schema.Add("MovementTypeName", typeof(string), "MovementTypeName", false);
                schema.Add("MovementCode", typeof(string), "MovementCode", false);
            }

            return schema;
        }

        public override void LoadDefaultValues()
        {
            SqlCommand command = Session.CreateCommand();

            this["MovementTypeID"] = DbConverter.DefaultInt();

            this["MovementTypeName"] = DbConverter.DefaultString();

            this["MovementCode"] = DbConverter.DefaultString();
        }

        public static TMovementTypes Load(int movementTypeID)
        {
            TMovementTypes result = new TMovementTypes();
            result.LoadRecord(movementTypeID);
            return result;
        }

        public static TMovementTypes CachedLoad(int movementTypeID)
        {
            DbCache.TableKey key = new DbCache.TableKey("TMovementTypes");
            DbCache.CacheRecord record;
            key.Set(movementTypeID);
            if (DbCache.Contains(key))
            {
                record = DbCache.GetRecord(key);
                if (!record.IsValid())
                {
                    record.Value = Load(movementTypeID);
                    record.LastUpdate = DateTime.Now;
                    record.Valid = true;
                }
            }
            else
            {
                record = new DbCache.CacheRecord();
                record.Value = Load(movementTypeID);
                record.LastUpdate = DateTime.Now;
                record.Valid = true;
                DbCache.SetRecord(key, record);
            }
            return (TMovementTypes)record.Value;
        }

        public static TMovementTypes Create()
        {
            TMovementTypes result = new TMovementTypes();
            result.LoadDefaultValues();
            return result;
        }

        public static DbTable<TMovementTypes> LoadAll()
        {
            DbTable<TMovementTypes> table = new DbTable<TMovementTypes>();
            TMovementTypes prototype = new TMovementTypes();
            prototype.LoadTable(table);
            return table;
        }

        public static DbTable<TMovementTypes> LoadBy(string whereCondition, params object[] parameterValues)
        {
            DbTable<TMovementTypes> table = new DbTable<TMovementTypes>();
            TMovementTypes prototype = new TMovementTypes();
            prototype.LoadTable(table, whereCondition, parameterValues);
            return table;
        }
    }

    public class CompTempNewCheckDupl: DbObject
    {
        private static DbSchema schema = null;

        public string Code
        {
            get { return DbConverter.ToString(this["Code"]); }
            set { this["Code"] = DbConverter.FromString(value); }
        }

        public DbNullable<string> VarNew
        {
            get { return DbConverter.ToStringNull(this["VarNew"]); }
            set { this["VarNew"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> CodeNrNew
        {
            get { return DbConverter.ToStringNull(this["CodeNrNew"]); }
            set { this["CodeNrNew"] = DbConverter.FromStringNull(value); }
        }

        protected override DbSchema GetSchema()
        {
            if (schema == null)
            {
                schema = new DbSchema("CompTempNewCheckDupl");
                schema.Add("Code", typeof(string), "Code", false, true, false);
                schema.Add("VarNew", typeof(string), "VarNew", true);
                schema.Add("CodeNrNew", typeof(string), "CodeNrNew", true);
            }

            return schema;
        }

        public override void LoadDefaultValues()
        {
            SqlCommand command = Session.CreateCommand();

            this["Code"] = DbConverter.DefaultString();

            this["VarNew"] = DBNull.Value;

            this["CodeNrNew"] = DBNull.Value;
        }

        public static CompTempNewCheckDupl Load(string code)
        {
            CompTempNewCheckDupl result = new CompTempNewCheckDupl();
            result.LoadRecord(code);
            return result;
        }

        public static CompTempNewCheckDupl CachedLoad(string code)
        {
            DbCache.TableKey key = new DbCache.TableKey("CompTempNewCheckDupl");
            DbCache.CacheRecord record;
            key.Set(code);
            if (DbCache.Contains(key))
            {
                record = DbCache.GetRecord(key);
                if (!record.IsValid())
                {
                    record.Value = Load(code);
                    record.LastUpdate = DateTime.Now;
                    record.Valid = true;
                }
            }
            else
            {
                record = new DbCache.CacheRecord();
                record.Value = Load(code);
                record.LastUpdate = DateTime.Now;
                record.Valid = true;
                DbCache.SetRecord(key, record);
            }
            return (CompTempNewCheckDupl)record.Value;
        }

        public static CompTempNewCheckDupl Create()
        {
            CompTempNewCheckDupl result = new CompTempNewCheckDupl();
            result.LoadDefaultValues();
            return result;
        }

        public static DbTable<CompTempNewCheckDupl> LoadAll()
        {
            DbTable<CompTempNewCheckDupl> table = new DbTable<CompTempNewCheckDupl>();
            CompTempNewCheckDupl prototype = new CompTempNewCheckDupl();
            prototype.LoadTable(table);
            return table;
        }

        public static DbTable<CompTempNewCheckDupl> LoadBy(string whereCondition, params object[] parameterValues)
        {
            DbTable<CompTempNewCheckDupl> table = new DbTable<CompTempNewCheckDupl>();
            CompTempNewCheckDupl prototype = new CompTempNewCheckDupl();
            prototype.LoadTable(table, whereCondition, parameterValues);
            return table;
        }
    }

    public class THistorie: DbObject
    {
        private static DbSchema schema = null;

        public int ID
        {
            get { return DbConverter.ToInt(this["ID"]); }
            set { this["ID"] = DbConverter.FromInt(value); }
        }

        public DbNullable<int> TableID
        {
            get { return DbConverter.ToIntNull(this["TableID"]); }
            set { this["TableID"] = DbConverter.FromIntNull(value); }
        }

        public DbNullable<string> TableField
        {
            get { return DbConverter.ToStringNull(this["TableField"]); }
            set { this["TableField"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> UpdateBy
        {
            get { return DbConverter.ToStringNull(this["UpdateBy"]); }
            set { this["UpdateBy"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<DateTime> UpdateDate
        {
            get { return DbConverter.ToDateTimeNull(this["UpdateDate"]); }
            set { this["UpdateDate"] = DbConverter.FromDateTimeNull(value); }
        }

        public DbNullable<string> OldValue
        {
            get { return DbConverter.ToStringNull(this["OldValue"]); }
            set { this["OldValue"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> NewValue
        {
            get { return DbConverter.ToStringNull(this["NewValue"]); }
            set { this["NewValue"] = DbConverter.FromStringNull(value); }
        }

        protected override DbSchema GetSchema()
        {
            if (schema == null)
            {
                schema = new DbSchema("THistorie");
                schema.Add("ID", typeof(int), "ID", false, true, true);
                schema.Add("TableID", typeof(int), "TableID", true);
                schema.Add("TableField", typeof(string), "TableField", true);
                schema.Add("UpdateBy", typeof(string), "UpdateBy", true);
                schema.Add("UpdateDate", typeof(DateTime), "UpdateDate", true);
                schema.Add("OldValue", typeof(string), "OldValue", true);
                schema.Add("NewValue", typeof(string), "NewValue", true);
            }

            return schema;
        }

        public override void LoadDefaultValues()
        {
            SqlCommand command = Session.CreateCommand();

            this["ID"] = DbConverter.DefaultInt();

            this["TableID"] = DBNull.Value;

            this["TableField"] = DBNull.Value;

            command.CommandText = "SELECT ([dbo].[FceUserMSSQL]())";
            this["UpdateBy"] = command.ExecuteScalar();

            command.CommandText = "SELECT (getdate())";
            this["UpdateDate"] = command.ExecuteScalar();

            this["OldValue"] = DBNull.Value;

            this["NewValue"] = DBNull.Value;
        }

        public static THistorie Load(int iD)
        {
            THistorie result = new THistorie();
            result.LoadRecord(iD);
            return result;
        }

        public static THistorie CachedLoad(int iD)
        {
            DbCache.TableKey key = new DbCache.TableKey("THistorie");
            DbCache.CacheRecord record;
            key.Set(iD);
            if (DbCache.Contains(key))
            {
                record = DbCache.GetRecord(key);
                if (!record.IsValid())
                {
                    record.Value = Load(iD);
                    record.LastUpdate = DateTime.Now;
                    record.Valid = true;
                }
            }
            else
            {
                record = new DbCache.CacheRecord();
                record.Value = Load(iD);
                record.LastUpdate = DateTime.Now;
                record.Valid = true;
                DbCache.SetRecord(key, record);
            }
            return (THistorie)record.Value;
        }

        public static THistorie Create()
        {
            THistorie result = new THistorie();
            result.LoadDefaultValues();
            return result;
        }

        public static DbTable<THistorie> LoadAll()
        {
            DbTable<THistorie> table = new DbTable<THistorie>();
            THistorie prototype = new THistorie();
            prototype.LoadTable(table);
            return table;
        }

        public static DbTable<THistorie> LoadByTableID(DbNullable<int> tableID)
        {
            DbTable<THistorie> table = new DbTable<THistorie>();
            THistorie prototype = new THistorie();
            prototype.LoadTable(table, "[TableID]={0}", DbConverter.FromIntNull(tableID));
            return table;
        }

        public static DbTable<THistorie> LoadBy(string whereCondition, params object[] parameterValues)
        {
            DbTable<THistorie> table = new DbTable<THistorie>();
            THistorie prototype = new THistorie();
            prototype.LoadTable(table, whereCondition, parameterValues);
            return table;
        }
    }

    public class TIFU: DbObject
    {
        private static DbSchema schema = null;

        public int IfuID
        {
            get { return DbConverter.ToInt(this["IfuID"]); }
            set { this["IfuID"] = DbConverter.FromInt(value); }
        }

        public string IfuType
        {
            get { return DbConverter.ToString(this["IfuType"]); }
            set { this["IfuType"] = DbConverter.FromString(value); }
        }

        public decimal IfuValue
        {
            get { return DbConverter.ToDecimal(this["IfuValue"]); }
            set { this["IfuValue"] = DbConverter.FromDecimal(value); }
        }

        protected override DbSchema GetSchema()
        {
            if (schema == null)
            {
                schema = new DbSchema("TIFU");
                schema.Add("IfuID", typeof(int), "IfuID", false, true, true);
                schema.Add("IfuType", typeof(string), "IfuType", false);
                schema.Add("IfuValue", typeof(decimal), "IfuValue", false);
            }

            return schema;
        }

        public override void LoadDefaultValues()
        {
            SqlCommand command = Session.CreateCommand();

            this["IfuID"] = DbConverter.DefaultInt();

            this["IfuType"] = DbConverter.DefaultString();

            this["IfuValue"] = DbConverter.DefaultDecimal();
        }

        public static TIFU Load(int ifuID)
        {
            TIFU result = new TIFU();
            result.LoadRecord(ifuID);
            return result;
        }

        public static TIFU CachedLoad(int ifuID)
        {
            DbCache.TableKey key = new DbCache.TableKey("TIFU");
            DbCache.CacheRecord record;
            key.Set(ifuID);
            if (DbCache.Contains(key))
            {
                record = DbCache.GetRecord(key);
                if (!record.IsValid())
                {
                    record.Value = Load(ifuID);
                    record.LastUpdate = DateTime.Now;
                    record.Valid = true;
                }
            }
            else
            {
                record = new DbCache.CacheRecord();
                record.Value = Load(ifuID);
                record.LastUpdate = DateTime.Now;
                record.Valid = true;
                DbCache.SetRecord(key, record);
            }
            return (TIFU)record.Value;
        }

        public static TIFU Create()
        {
            TIFU result = new TIFU();
            result.LoadDefaultValues();
            return result;
        }

        public static DbTable<TIFU> LoadAll()
        {
            DbTable<TIFU> table = new DbTable<TIFU>();
            TIFU prototype = new TIFU();
            prototype.LoadTable(table);
            return table;
        }

        public static DbTable<TIFU> LoadBy(string whereCondition, params object[] parameterValues)
        {
            DbTable<TIFU> table = new DbTable<TIFU>();
            TIFU prototype = new TIFU();
            prototype.LoadTable(table, whereCondition, parameterValues);
            return table;
        }
    }

    public class ImportXS: DbObject
    {
        private static DbSchema schema = null;

        public int ID
        {
            get { return DbConverter.ToInt(this["ID"]); }
            set { this["ID"] = DbConverter.FromInt(value); }
        }

        public DbNullable<double> Notification
        {
            get { return DbConverter.ToDoubleNull(this["Notification"]); }
            set { this["Notification"] = DbConverter.FromDoubleNull(value); }
        }

        public DbNullable<string> Month
        {
            get { return DbConverter.ToStringNull(this["Month"]); }
            set { this["Month"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> Country
        {
            get { return DbConverter.ToStringNull(this["Country"]); }
            set { this["Country"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> Customer
        {
            get { return DbConverter.ToStringNull(this["Customer"]); }
            set { this["Customer"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> C_C
        {
            get { return DbConverter.ToStringNull(this["C C"]); }
            set { this["C C"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<DateTime> Created_on
        {
            get { return DbConverter.ToDateTimeNull(this["Created on"]); }
            set { this["Created on"] = DbConverter.FromDateTimeNull(value); }
        }

        public DbNullable<string> Manufact
        {
            get { return DbConverter.ToStringNull(this["Manufact"]); }
            set { this["Manufact"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> Plant
        {
            get { return DbConverter.ToStringNull(this["Plant"]); }
            set { this["Plant"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> Field9
        {
            get { return DbConverter.ToStringNull(this["Field9"]); }
            set { this["Field9"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> Material
        {
            get { return DbConverter.ToStringNull(this["Material"]); }
            set { this["Material"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> LOT
        {
            get { return DbConverter.ToStringNull(this["LOT"]); }
            set { this["LOT"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> Type
        {
            get { return DbConverter.ToStringNull(this["Type"]); }
            set { this["Type"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> Description_of_the_problem_by_CC
        {
            get { return DbConverter.ToStringNull(this["Description of the problem by CC"]); }
            set { this["Description of the problem by CC"] = DbConverter.FromStringNull(value); }
        }

        // TDOO Ka_defect
        public DbNullable<string> Ka_defect
        {
            get { return DbConverter.ToStringNull(this["Ka_defect"]); }
            set { this["Ka_defect"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> Penalty_for_production
        {
            get { return DbConverter.ToStringNull(this["Penalty for production"]); }
            set { this["Penalty for production"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> Defect_type
        {
            get { return DbConverter.ToStringNull(this["Defect type"]); }
            set { this["Defect type"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> ZV_Notification
        {
            get { return DbConverter.ToStringNull(this["ZV Notification"]); }
            set { this["ZV Notification"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> Contact
        {
            get { return DbConverter.ToStringNull(this["Contact"]); }
            set { this["Contact"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> Quant
        {
            get { return DbConverter.ToStringNull(this["Quant"]); }
            set { this["Quant"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> Complaint_status
        {
            get { return DbConverter.ToStringNull(this["Complaint status"]); }
            set { this["Complaint status"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> CHF_comment
        {
            get { return DbConverter.ToStringNull(this["CHF comment"]); }
            set { this["CHF comment"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> Reference_notification_or_CAPA
        {
            get { return DbConverter.ToStringNull(this["Reference notification or CAPA"]); }
            set { this["Reference notification or CAPA"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> Samples
        {
            get { return DbConverter.ToStringNull(this["Samples"]); }
            set { this["Samples"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> R
        {
            get { return DbConverter.ToStringNull(this["R"]); }
            set { this["R"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> Related_concession
        {
            get { return DbConverter.ToStringNull(this["Related concession"]); }
            set { this["Related concession"] = DbConverter.FromStringNull(value); }
        }

        // TODO remove ()
        public DbNullable<string> Affected_component
        {
            get { return DbConverter.ToStringNull(this["Affected component"]); }
            set { this["Affected component"] = DbConverter.FromStringNull(value); }
        }

        // TODO remove -
        public DbNullable<string> Support_column_for_sorting_I
        {
            get { return DbConverter.ToStringNull(this["Support column for sorting I"]); }
            set { this["Support column for sorting I"] = DbConverter.FromStringNull(value); }
        }


        // TODO remove '
        public DbNullable<string> Samples_delivery_date
        {
            get { return DbConverter.ToStringNull(this["Samples delivery date"]); }
            set { this["Samples delivery date"] = DbConverter.FromStringNull(value); }
        }

        // TODO remove '
        public DbNullable<string> Complaints_finish_date
        {
            get { return DbConverter.ToStringNull(this["Complaints finish date"]); }
            set { this["Complaints finish date"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> Field30
        {
            get { return DbConverter.ToStringNull(this["Field30"]); }
            set { this["Field30"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> Responsible_for_complaint
        {
            get { return DbConverter.ToStringNull(this["Responsible for complaint"]); }
            set { this["Responsible for complaint"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<DateTime> SamplesDate
        {
            get { return DbConverter.ToDateTimeNull(this["SamplesDate"]); }
            set { this["SamplesDate"] = DbConverter.FromDateTimeNull(value); }
        }

        public DbNullable<DateTime> FinishDate
        {
            get { return DbConverter.ToDateTimeNull(this["FinishDate"]); }
            set { this["FinishDate"] = DbConverter.FromDateTimeNull(value); }
        }

        protected override DbSchema GetSchema()
        {
            if (schema == null)
            {
                schema = new DbSchema("ImportXS");
                schema.Add("ID", typeof(int), "ID", false);
                schema.Add("Notification", typeof(double), "Notification", true);
                schema.Add("Month", typeof(string), "Month", true);
                schema.Add("Country", typeof(string), "Country", true);
                schema.Add("Customer", typeof(string), "Customer", true);
                schema.Add("C C", typeof(string), "C C", true);
                schema.Add("Created on", typeof(DateTime), "Created on", true);
                schema.Add("Manufact", typeof(string), "Manufact", true);
                schema.Add("Plant", typeof(string), "Plant", true);
                schema.Add("Field9", typeof(string), "Field9", true);
                schema.Add("Material", typeof(string), "Material", true);
                schema.Add("LOT", typeof(string), "LOT", true);
                schema.Add("Type", typeof(string), "Type", true);
                schema.Add("Description of the problem by CC", typeof(string), "Description of the problem by CC", true);
                schema.Add("Ka-defect", typeof(string), "Ka-defect", true);
                schema.Add("Penalty for production", typeof(string), "Penalty for production", true);
                schema.Add("Defect type", typeof(string), "Defect type", true);
                schema.Add("ZV Notification", typeof(string), "ZV Notification", true);
                schema.Add("Contact", typeof(string), "Contact", true);
                schema.Add("Quant", typeof(string), "Quant", true);
                schema.Add("Complaint status", typeof(string), "Complaint status", true);
                schema.Add("CHF comment", typeof(string), "CHF comment", true);
                schema.Add("Reference notification or CAPA", typeof(string), "Reference notification or CAPA", true);
                schema.Add("Samples", typeof(string), "Samples", true);
                schema.Add("R", typeof(string), "R", true);
                schema.Add("Related concession", typeof(string), "Related concession", true);
                schema.Add("Affected component(s)", typeof(string), "Affected component(s)", true);
                schema.Add("Support column for sorting - I", typeof(string), "Support column for sorting - I", true);
                schema.Add("Sample's delivery date", typeof(string), "Sample's delivery date", true);
                schema.Add("Complaint's finish date", typeof(string), "Complaint's finish date", true);
                schema.Add("Field30", typeof(string), "Field30", true);
                schema.Add("Responsible for complaint", typeof(string), "Responsible for complaint", true);
                schema.Add("SamplesDate", typeof(DateTime), "SamplesDate", true);
                schema.Add("FinishDate", typeof(DateTime), "FinishDate", true);
            }

            return schema;
        }

        public override void LoadDefaultValues()
        {
            SqlCommand command = Session.CreateCommand();

            this["ID"] = DbConverter.DefaultInt();

            this["Notification"] = DBNull.Value;

            this["Month"] = DBNull.Value;

            this["Country"] = DBNull.Value;

            this["Customer"] = DBNull.Value;

            this["C C"] = DBNull.Value;

            this["Created on"] = DBNull.Value;

            this["Manufact"] = DBNull.Value;

            this["Plant"] = DBNull.Value;

            this["Field9"] = DBNull.Value;

            this["Material"] = DBNull.Value;

            this["LOT"] = DBNull.Value;

            this["Type"] = DBNull.Value;

            this["Description of the problem by CC"] = DBNull.Value;

            this["Ka-defect"] = DBNull.Value;

            this["Penalty for production"] = DBNull.Value;

            this["Defect type"] = DBNull.Value;

            this["ZV Notification"] = DBNull.Value;

            this["Contact"] = DBNull.Value;

            this["Quant"] = DBNull.Value;

            this["Complaint status"] = DBNull.Value;

            this["CHF comment"] = DBNull.Value;

            this["Reference notification or CAPA"] = DBNull.Value;

            this["Samples"] = DBNull.Value;

            this["R"] = DBNull.Value;

            this["Related concession"] = DBNull.Value;

            this["Affected component(s)"] = DBNull.Value;

            this["Support column for sorting - I"] = DBNull.Value;

            this["Sample's delivery date"] = DBNull.Value;

            this["Complaint's finish date"] = DBNull.Value;

            this["Field30"] = DBNull.Value;

            this["Responsible for complaint"] = DBNull.Value;

            this["SamplesDate"] = DBNull.Value;

            this["FinishDate"] = DBNull.Value;
        }

        public static ImportXS Load()
        {
            ImportXS result = new ImportXS();
            result.LoadRecord();
            return result;
        }

        public static ImportXS CachedLoad()
        {
            DbCache.TableKey key = new DbCache.TableKey("ImportXS");
            DbCache.CacheRecord record;
            key.Set();
            if (DbCache.Contains(key))
            {
                record = DbCache.GetRecord(key);
                if (!record.IsValid())
                {
                    record.Value = Load();
                    record.LastUpdate = DateTime.Now;
                    record.Valid = true;
                }
            }
            else
            {
                record = new DbCache.CacheRecord();
                record.Value = Load();
                record.LastUpdate = DateTime.Now;
                record.Valid = true;
                DbCache.SetRecord(key, record);
            }
            return (ImportXS)record.Value;
        }

        public static ImportXS Create()
        {
            ImportXS result = new ImportXS();
            result.LoadDefaultValues();
            return result;
        }

        public static DbTable<ImportXS> LoadAll()
        {
            DbTable<ImportXS> table = new DbTable<ImportXS>();
            ImportXS prototype = new ImportXS();
            prototype.LoadTable(table);
            return table;
        }

        public static DbTable<ImportXS> LoadBy(string whereCondition, params object[] parameterValues)
        {
            DbTable<ImportXS> table = new DbTable<ImportXS>();
            ImportXS prototype = new ImportXS();
            prototype.LoadTable(table, whereCondition, parameterValues);
            return table;
        }
    }

    public class TComposition: DbObject
    {
        private static DbSchema schema = null;

        public int IDComposition
        {
            get { return DbConverter.ToInt(this["IDComposition"]); }
            set { this["IDComposition"] = DbConverter.FromInt(value); }
        }

        public string CompositionName
        {
            get { return DbConverter.ToString(this["CompositionName"]); }
            set { this["CompositionName"] = DbConverter.FromString(value); }
        }

        protected override DbSchema GetSchema()
        {
            if (schema == null)
            {
                schema = new DbSchema("TComposition");
                schema.Add("IDComposition", typeof(int), "IDComposition", false, true, true);
                schema.Add("CompositionName", typeof(string), "CompositionName", false);
            }

            return schema;
        }

        public override void LoadDefaultValues()
        {
            SqlCommand command = Session.CreateCommand();

            this["IDComposition"] = DbConverter.DefaultInt();

            this["CompositionName"] = DbConverter.DefaultString();
        }

        public static TComposition Load(int iDComposition)
        {
            TComposition result = new TComposition();
            result.LoadRecord(iDComposition);
            return result;
        }

        public static TComposition CachedLoad(int iDComposition)
        {
            DbCache.TableKey key = new DbCache.TableKey("TComposition");
            DbCache.CacheRecord record;
            key.Set(iDComposition);
            if (DbCache.Contains(key))
            {
                record = DbCache.GetRecord(key);
                if (!record.IsValid())
                {
                    record.Value = Load(iDComposition);
                    record.LastUpdate = DateTime.Now;
                    record.Valid = true;
                }
            }
            else
            {
                record = new DbCache.CacheRecord();
                record.Value = Load(iDComposition);
                record.LastUpdate = DateTime.Now;
                record.Valid = true;
                DbCache.SetRecord(key, record);
            }
            return (TComposition)record.Value;
        }

        public static TComposition Create()
        {
            TComposition result = new TComposition();
            result.LoadDefaultValues();
            return result;
        }

        public static DbTable<TComposition> LoadAll()
        {
            DbTable<TComposition> table = new DbTable<TComposition>();
            TComposition prototype = new TComposition();
            prototype.LoadTable(table);
            return table;
        }

        public static DbTable<TComposition> LoadBy(string whereCondition, params object[] parameterValues)
        {
            DbTable<TComposition> table = new DbTable<TComposition>();
            TComposition prototype = new TComposition();
            prototype.LoadTable(table, whereCondition, parameterValues);
            return table;
        }
    }

    public class TTimesRevisionDetail: DbObject
    {
        private static DbSchema schema = null;

        public int TimesRevisionDetailID
        {
            get { return DbConverter.ToInt(this["TimesRevisionDetailID"]); }
            set { this["TimesRevisionDetailID"] = DbConverter.FromInt(value); }
        }

        public int TimesRevision
        {
            get { return DbConverter.ToInt(this["TimesRevision"]); }
            set { this["TimesRevision"] = DbConverter.FromInt(value); }
        }

        public int Image
        {
            get { return DbConverter.ToInt(this["Image"]); }
            set { this["Image"] = DbConverter.FromInt(value); }
        }

        public DbNullable<decimal> VS
        {
            get { return DbConverter.ToDecimalNull(this["VS"]); }
            set { this["VS"] = DbConverter.FromDecimalNull(value); }
        }

        public DbNullable<decimal> VV
        {
            get { return DbConverter.ToDecimalNull(this["VV"]); }
            set { this["VV"] = DbConverter.FromDecimalNull(value); }
        }

        public DbNullable<decimal> VM
        {
            get { return DbConverter.ToDecimalNull(this["VM"]); }
            set { this["VM"] = DbConverter.FromDecimalNull(value); }
        }

        public DbNullable<decimal> VP
        {
            get { return DbConverter.ToDecimalNull(this["VP"]); }
            set { this["VP"] = DbConverter.FromDecimalNull(value); }
        }

        public DbNullable<decimal> PP
        {
            get { return DbConverter.ToDecimalNull(this["PP"]); }
            set { this["PP"] = DbConverter.FromDecimalNull(value); }
        }

        public DbNullable<decimal> PM
        {
            get { return DbConverter.ToDecimalNull(this["PM"]); }
            set { this["PM"] = DbConverter.FromDecimalNull(value); }
        }

        public DbNullable<decimal> K
        {
            get { return DbConverter.ToDecimalNull(this["K"]); }
            set { this["K"] = DbConverter.FromDecimalNull(value); }
        }

        public DbNullable<decimal> Routing
        {
            get { return DbConverter.ToDecimalNull(this["Routing"]); }
            set { this["Routing"] = DbConverter.FromDecimalNull(value); }
        }

        public DbNullable<decimal> TimeSAP
        {
            get { return DbConverter.ToDecimalNull(this["TimeSAP"]); }
            set { this["TimeSAP"] = DbConverter.FromDecimalNull(value); }
        }

        public DbNullable<int> SourceImage
        {
            get { return DbConverter.ToIntNull(this["SourceImage"]); }
            set { this["SourceImage"] = DbConverter.FromIntNull(value); }
        }

        public DbNullable<DateTime> ExportDate
        {
            get { return DbConverter.ToDateTimeNull(this["ExportDate"]); }
            set { this["ExportDate"] = DbConverter.FromDateTimeNull(value); }
        }

        public DateTime Created
        {
            get { return DbConverter.ToDateTime(this["Created"]); }
            set { this["Created"] = DbConverter.FromDateTime(value); }
        }

        public string CreatedBY
        {
            get { return DbConverter.ToString(this["CreatedBY"]); }
            set { this["CreatedBY"] = DbConverter.FromString(value); }
        }

        public DbNullable<int> CounterNo
        {
            get { return DbConverter.ToIntNull(this["CounterNo"]); }
            set { this["CounterNo"] = DbConverter.FromIntNull(value); }
        }

        public bool CancelImage
        {
            get { return DbConverter.ToBool(this["CancelImage"]); }
            set { this["CancelImage"] = DbConverter.FromBool(value); }
        }

        public DbNullable<string> ZdrojTmp
        {
            get { return DbConverter.ToStringNull(this["ZdrojTmp"]); }
            set { this["ZdrojTmp"] = DbConverter.FromStringNull(value); }
        }

        protected override DbSchema GetSchema()
        {
            if (schema == null)
            {
                schema = new DbSchema("TTimesRevisionDetail");
                schema.Add("TimesRevisionDetailID", typeof(int), "TimesRevisionDetailID", false, true, true);
                schema.Add("TimesRevision", typeof(int), "TimesRevision", false);
                schema.Add("Image", typeof(int), "Image", false);
                schema.Add("VS", typeof(decimal), "VS", true);
                schema.Add("VV", typeof(decimal), "VV", true);
                schema.Add("VM", typeof(decimal), "VM", true);
                schema.Add("VP", typeof(decimal), "VP", true);
                schema.Add("PP", typeof(decimal), "PP", true);
                schema.Add("PM", typeof(decimal), "PM", true);
                schema.Add("K", typeof(decimal), "K", true);
                schema.Add("Routing", typeof(decimal), "Routing", true);
                schema.Add("TimeSAP", typeof(decimal), "TimeSAP", true);
                schema.Add("SourceImage", typeof(int), "SourceImage", true);
                schema.Add("ExportDate", typeof(DateTime), "ExportDate", true);
                schema.Add("Created", typeof(DateTime), "Created", false);
                schema.Add("CreatedBY", typeof(string), "CreatedBY", false);
                schema.Add("CounterNo", typeof(int), "CounterNo", true);
                schema.Add("CancelImage", typeof(bool), "CancelImage", false);
                schema.Add("ZdrojTmp", typeof(string), "ZdrojTmp", true);
            }

            return schema;
        }

        public override void LoadDefaultValues()
        {
            SqlCommand command = Session.CreateCommand();

            this["TimesRevisionDetailID"] = DbConverter.DefaultInt();

            this["TimesRevision"] = DbConverter.DefaultInt();

            this["Image"] = DbConverter.DefaultInt();

            this["VS"] = DBNull.Value;

            this["VV"] = DBNull.Value;

            this["VM"] = DBNull.Value;

            this["VP"] = DBNull.Value;

            this["PP"] = DBNull.Value;

            this["PM"] = DBNull.Value;

            this["K"] = DBNull.Value;

            this["Routing"] = DBNull.Value;

            this["TimeSAP"] = DBNull.Value;

            this["SourceImage"] = DBNull.Value;

            this["ExportDate"] = DBNull.Value;

            command.CommandText = "SELECT (getdate())";
            this["Created"] = command.ExecuteScalar();

            command.CommandText = "SELECT ([dbo].[FceUserMSSQL]())";
            this["CreatedBY"] = command.ExecuteScalar();

            this["CounterNo"] = DBNull.Value;

            command.CommandText = "SELECT ((0))";
            this["CancelImage"] = command.ExecuteScalar();

            this["ZdrojTmp"] = DBNull.Value;
        }

        public static TTimesRevisionDetail Load(int timesRevisionDetailID)
        {
            TTimesRevisionDetail result = new TTimesRevisionDetail();
            result.LoadRecord(timesRevisionDetailID);
            return result;
        }

        public static TTimesRevisionDetail CachedLoad(int timesRevisionDetailID)
        {
            DbCache.TableKey key = new DbCache.TableKey("TTimesRevisionDetail");
            DbCache.CacheRecord record;
            key.Set(timesRevisionDetailID);
            if (DbCache.Contains(key))
            {
                record = DbCache.GetRecord(key);
                if (!record.IsValid())
                {
                    record.Value = Load(timesRevisionDetailID);
                    record.LastUpdate = DateTime.Now;
                    record.Valid = true;
                }
            }
            else
            {
                record = new DbCache.CacheRecord();
                record.Value = Load(timesRevisionDetailID);
                record.LastUpdate = DateTime.Now;
                record.Valid = true;
                DbCache.SetRecord(key, record);
            }
            return (TTimesRevisionDetail)record.Value;
        }

        public static TTimesRevisionDetail Create()
        {
            TTimesRevisionDetail result = new TTimesRevisionDetail();
            result.LoadDefaultValues();
            return result;
        }

        public static DbTable<TTimesRevisionDetail> LoadAll()
        {
            DbTable<TTimesRevisionDetail> table = new DbTable<TTimesRevisionDetail>();
            TTimesRevisionDetail prototype = new TTimesRevisionDetail();
            prototype.LoadTable(table);
            return table;
        }

        public static DbTable<TTimesRevisionDetail> LoadByTimesRevision(int timesRevision)
        {
            DbTable<TTimesRevisionDetail> table = new DbTable<TTimesRevisionDetail>();
            TTimesRevisionDetail prototype = new TTimesRevisionDetail();
            prototype.LoadTable(table, "[TimesRevision]={0}", DbConverter.FromInt(timesRevision));
            return table;
        }

        public static DbTable<TTimesRevisionDetail> LoadByImage(int image)
        {
            DbTable<TTimesRevisionDetail> table = new DbTable<TTimesRevisionDetail>();
            TTimesRevisionDetail prototype = new TTimesRevisionDetail();
            prototype.LoadTable(table, "[Image]={0}", DbConverter.FromInt(image));
            return table;
        }

        public static DbTable<TTimesRevisionDetail> LoadBySourceImage(DbNullable<int> sourceImage)
        {
            DbTable<TTimesRevisionDetail> table = new DbTable<TTimesRevisionDetail>();
            TTimesRevisionDetail prototype = new TTimesRevisionDetail();
            prototype.LoadTable(table, "[SourceImage]={0}", DbConverter.FromIntNull(sourceImage));
            return table;
        }

        public static DbTable<TTimesRevisionDetail> LoadBy(string whereCondition, params object[] parameterValues)
        {
            DbTable<TTimesRevisionDetail> table = new DbTable<TTimesRevisionDetail>();
            TTimesRevisionDetail prototype = new TTimesRevisionDetail();
            prototype.LoadTable(table, whereCondition, parameterValues);
            return table;
        }
    }

    public class CompTempNew: DbObject
    {
        private static DbSchema schema = null;

        public string Code
        {
            get { return DbConverter.ToString(this["Code"]); }
            set { this["Code"] = DbConverter.FromString(value); }
        }

        public string Status
        {
            get { return DbConverter.ToString(this["Status"]); }
            set { this["Status"] = DbConverter.FromString(value); }
        }

        protected override DbSchema GetSchema()
        {
            if (schema == null)
            {
                schema = new DbSchema("CompTempNew");
                schema.Add("Code", typeof(string), "Code", false, true, false);
                schema.Add("Status", typeof(string), "Status", false);
            }

            return schema;
        }

        public override void LoadDefaultValues()
        {
            SqlCommand command = Session.CreateCommand();

            this["Code"] = DbConverter.DefaultString();

            this["Status"] = DbConverter.DefaultString();
        }

        public static CompTempNew Load(string code)
        {
            CompTempNew result = new CompTempNew();
            result.LoadRecord(code);
            return result;
        }

        public static CompTempNew CachedLoad(string code)
        {
            DbCache.TableKey key = new DbCache.TableKey("CompTempNew");
            DbCache.CacheRecord record;
            key.Set(code);
            if (DbCache.Contains(key))
            {
                record = DbCache.GetRecord(key);
                if (!record.IsValid())
                {
                    record.Value = Load(code);
                    record.LastUpdate = DateTime.Now;
                    record.Valid = true;
                }
            }
            else
            {
                record = new DbCache.CacheRecord();
                record.Value = Load(code);
                record.LastUpdate = DateTime.Now;
                record.Valid = true;
                DbCache.SetRecord(key, record);
            }
            return (CompTempNew)record.Value;
        }

        public static CompTempNew Create()
        {
            CompTempNew result = new CompTempNew();
            result.LoadDefaultValues();
            return result;
        }

        public static DbTable<CompTempNew> LoadAll()
        {
            DbTable<CompTempNew> table = new DbTable<CompTempNew>();
            CompTempNew prototype = new CompTempNew();
            prototype.LoadTable(table);
            return table;
        }

        public static DbTable<CompTempNew> LoadBy(string whereCondition, params object[] parameterValues)
        {
            DbTable<CompTempNew> table = new DbTable<CompTempNew>();
            CompTempNew prototype = new CompTempNew();
            prototype.LoadTable(table, whereCondition, parameterValues);
            return table;
        }
    }

    public class THistoryUpdates: DbObject
    {
        private static DbSchema schema = null;

        public int ID
        {
            get { return DbConverter.ToInt(this["ID"]); }
            set { this["ID"] = DbConverter.FromInt(value); }
        }

        public DbNullable<string> TableName
        {
            get { return DbConverter.ToStringNull(this["TableName"]); }
            set { this["TableName"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<int> TableID
        {
            get { return DbConverter.ToIntNull(this["TableID"]); }
            set { this["TableID"] = DbConverter.FromIntNull(value); }
        }

        public DbNullable<string> TableField
        {
            get { return DbConverter.ToStringNull(this["TableField"]); }
            set { this["TableField"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> UpdatedBy
        {
            get { return DbConverter.ToStringNull(this["UpdatedBy"]); }
            set { this["UpdatedBy"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<DateTime> UpdatedDate
        {
            get { return DbConverter.ToDateTimeNull(this["UpdatedDate"]); }
            set { this["UpdatedDate"] = DbConverter.FromDateTimeNull(value); }
        }

        public DbNullable<string> OldValue
        {
            get { return DbConverter.ToStringNull(this["OldValue"]); }
            set { this["OldValue"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> NewValue
        {
            get { return DbConverter.ToStringNull(this["NewValue"]); }
            set { this["NewValue"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<int> OldValueID
        {
            get { return DbConverter.ToIntNull(this["OldValueID"]); }
            set { this["OldValueID"] = DbConverter.FromIntNull(value); }
        }

        public DbNullable<int> NewValueID
        {
            get { return DbConverter.ToIntNull(this["NewValueID"]); }
            set { this["NewValueID"] = DbConverter.FromIntNull(value); }
        }

        public bool Checked
        {
            get { return DbConverter.ToBool(this["Checked"]); }
            set { this["Checked"] = DbConverter.FromBool(value); }
        }

        public DbNullable<int> CheckedBy
        {
            get { return DbConverter.ToIntNull(this["CheckedBy"]); }
            set { this["CheckedBy"] = DbConverter.FromIntNull(value); }
        }

        public DbNullable<DateTime> CheckedDate
        {
            get { return DbConverter.ToDateTimeNull(this["CheckedDate"]); }
            set { this["CheckedDate"] = DbConverter.FromDateTimeNull(value); }
        }

        public DbNullable<string> TableInfo
        {
            get { return DbConverter.ToStringNull(this["TableInfo"]); }
            set { this["TableInfo"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> OperationInfo
        {
            get { return DbConverter.ToStringNull(this["OperationInfo"]); }
            set { this["OperationInfo"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> MasterTableName
        {
            get { return DbConverter.ToStringNull(this["MasterTableName"]); }
            set { this["MasterTableName"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<int> MasterTableID
        {
            get { return DbConverter.ToIntNull(this["MasterTableID"]); }
            set { this["MasterTableID"] = DbConverter.FromIntNull(value); }
        }

        public DbNullable<DateTime> OldDateFrom
        {
            get { return DbConverter.ToDateTimeNull(this["OldDateFrom"]); }
            set { this["OldDateFrom"] = DbConverter.FromDateTimeNull(value); }
        }

        protected override DbSchema GetSchema()
        {
            if (schema == null)
            {
                schema = new DbSchema("THistoryUpdates");
                schema.Add("ID", typeof(int), "ID", false, true, true);
                schema.Add("TableName", typeof(string), "TableName", true);
                schema.Add("TableID", typeof(int), "TableID", true);
                schema.Add("TableField", typeof(string), "TableField", true);
                schema.Add("UpdatedBy", typeof(string), "UpdatedBy", true);
                schema.Add("UpdatedDate", typeof(DateTime), "UpdatedDate", true);
                schema.Add("OldValue", typeof(string), "OldValue", true);
                schema.Add("NewValue", typeof(string), "NewValue", true);
                schema.Add("OldValueID", typeof(int), "OldValueID", true);
                schema.Add("NewValueID", typeof(int), "NewValueID", true);
                schema.Add("Checked", typeof(bool), "Checked", false);
                schema.Add("CheckedBy", typeof(int), "CheckedBy", true);
                schema.Add("CheckedDate", typeof(DateTime), "CheckedDate", true);
                schema.Add("TableInfo", typeof(string), "TableInfo", true);
                schema.Add("OperationInfo", typeof(string), "OperationInfo", true);
                schema.Add("MasterTableName", typeof(string), "MasterTableName", true);
                schema.Add("MasterTableID", typeof(int), "MasterTableID", true);
                schema.Add("OldDateFrom", typeof(DateTime), "OldDateFrom", true);
            }

            return schema;
        }

        public override void LoadDefaultValues()
        {
            SqlCommand command = Session.CreateCommand();

            this["ID"] = DbConverter.DefaultInt();

            this["TableName"] = DBNull.Value;

            this["TableID"] = DBNull.Value;

            this["TableField"] = DBNull.Value;

            command.CommandText = "SELECT ([dbo].[FceUserMSSQL]())";
            this["UpdatedBy"] = command.ExecuteScalar();

            command.CommandText = "SELECT (getdate())";
            this["UpdatedDate"] = command.ExecuteScalar();

            this["OldValue"] = DBNull.Value;

            this["NewValue"] = DBNull.Value;

            this["OldValueID"] = DBNull.Value;

            this["NewValueID"] = DBNull.Value;

            command.CommandText = "SELECT (0)";
            this["Checked"] = command.ExecuteScalar();

            this["CheckedBy"] = DBNull.Value;

            this["CheckedDate"] = DBNull.Value;

            this["TableInfo"] = DBNull.Value;

            this["OperationInfo"] = DBNull.Value;

            this["MasterTableName"] = DBNull.Value;

            this["MasterTableID"] = DBNull.Value;

            this["OldDateFrom"] = DBNull.Value;
        }

        public static THistoryUpdates Load(int iD)
        {
            THistoryUpdates result = new THistoryUpdates();
            result.LoadRecord(iD);
            return result;
        }

        public static THistoryUpdates CachedLoad(int iD)
        {
            DbCache.TableKey key = new DbCache.TableKey("THistoryUpdates");
            DbCache.CacheRecord record;
            key.Set(iD);
            if (DbCache.Contains(key))
            {
                record = DbCache.GetRecord(key);
                if (!record.IsValid())
                {
                    record.Value = Load(iD);
                    record.LastUpdate = DateTime.Now;
                    record.Valid = true;
                }
            }
            else
            {
                record = new DbCache.CacheRecord();
                record.Value = Load(iD);
                record.LastUpdate = DateTime.Now;
                record.Valid = true;
                DbCache.SetRecord(key, record);
            }
            return (THistoryUpdates)record.Value;
        }

        public static THistoryUpdates Create()
        {
            THistoryUpdates result = new THistoryUpdates();
            result.LoadDefaultValues();
            return result;
        }

        public static DbTable<THistoryUpdates> LoadAll()
        {
            DbTable<THistoryUpdates> table = new DbTable<THistoryUpdates>();
            THistoryUpdates prototype = new THistoryUpdates();
            prototype.LoadTable(table);
            return table;
        }

        public static DbTable<THistoryUpdates> LoadBy(string whereCondition, params object[] parameterValues)
        {
            DbTable<THistoryUpdates> table = new DbTable<THistoryUpdates>();
            THistoryUpdates prototype = new THistoryUpdates();
            prototype.LoadTable(table, whereCondition, parameterValues);
            return table;
        }
    }

    public class TBatchDetail: DbObject
    {
        private static DbSchema schema = null;

        public int ID
        {
            get { return DbConverter.ToInt(this["ID"]); }
            set { this["ID"] = DbConverter.FromInt(value); }
        }

        public int BatchID
        {
            get { return DbConverter.ToInt(this["BatchID"]); }
            set { this["BatchID"] = DbConverter.FromInt(value); }
        }

        public DbNullable<string> ComponentCode
        {
            get { return DbConverter.ToStringNull(this["ComponentCode"]); }
            set { this["ComponentCode"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<decimal> PcPerSet
        {
            get { return DbConverter.ToDecimalNull(this["PcPerSet"]); }
            set { this["PcPerSet"] = DbConverter.FromDecimalNull(value); }
        }

        public DbNullable<string> CompbatchNumber
        {
            get { return DbConverter.ToStringNull(this["CompbatchNumber"]); }
            set { this["CompbatchNumber"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> Expiration
        {
            get { return DbConverter.ToStringNull(this["Expiration"]); }
            set { this["Expiration"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<DateTime> DateWrite
        {
            get { return DbConverter.ToDateTimeNull(this["DateWrite"]); }
            set { this["DateWrite"] = DbConverter.FromDateTimeNull(value); }
        }

        public DbNullable<string> UserWrite
        {
            get { return DbConverter.ToStringNull(this["UserWrite"]); }
            set { this["UserWrite"] = DbConverter.FromStringNull(value); }
        }

        protected override DbSchema GetSchema()
        {
            if (schema == null)
            {
                schema = new DbSchema("TBatchDetail");
                schema.Add("ID", typeof(int), "ID", false, true, true);
                schema.Add("BatchID", typeof(int), "BatchID", false);
                schema.Add("ComponentCode", typeof(string), "ComponentCode", true);
                schema.Add("PcPerSet", typeof(decimal), "PcPerSet", true);
                schema.Add("CompbatchNumber", typeof(string), "CompbatchNumber", true);
                schema.Add("Expiration", typeof(string), "Expiration", true);
                schema.Add("DateWrite", typeof(DateTime), "DateWrite", true);
                schema.Add("UserWrite", typeof(string), "UserWrite", true);
            }

            return schema;
        }

        public override void LoadDefaultValues()
        {
            SqlCommand command = Session.CreateCommand();

            this["ID"] = DbConverter.DefaultInt();

            this["BatchID"] = DbConverter.DefaultInt();

            this["ComponentCode"] = DBNull.Value;

            this["PcPerSet"] = DBNull.Value;

            this["CompbatchNumber"] = DBNull.Value;

            this["Expiration"] = DBNull.Value;

            command.CommandText = "SELECT (getdate())";
            this["DateWrite"] = command.ExecuteScalar();

            this["UserWrite"] = DBNull.Value;
        }

        public static TBatchDetail Load(int iD)
        {
            TBatchDetail result = new TBatchDetail();
            result.LoadRecord(iD);
            return result;
        }

        public static TBatchDetail CachedLoad(int iD)
        {
            DbCache.TableKey key = new DbCache.TableKey("TBatchDetail");
            DbCache.CacheRecord record;
            key.Set(iD);
            if (DbCache.Contains(key))
            {
                record = DbCache.GetRecord(key);
                if (!record.IsValid())
                {
                    record.Value = Load(iD);
                    record.LastUpdate = DateTime.Now;
                    record.Valid = true;
                }
            }
            else
            {
                record = new DbCache.CacheRecord();
                record.Value = Load(iD);
                record.LastUpdate = DateTime.Now;
                record.Valid = true;
                DbCache.SetRecord(key, record);
            }
            return (TBatchDetail)record.Value;
        }

        public static TBatchDetail Create()
        {
            TBatchDetail result = new TBatchDetail();
            result.LoadDefaultValues();
            return result;
        }

        public static DbTable<TBatchDetail> LoadAll()
        {
            DbTable<TBatchDetail> table = new DbTable<TBatchDetail>();
            TBatchDetail prototype = new TBatchDetail();
            prototype.LoadTable(table);
            return table;
        }

        public static DbTable<TBatchDetail> LoadByBatchID(int batchID)
        {
            DbTable<TBatchDetail> table = new DbTable<TBatchDetail>();
            TBatchDetail prototype = new TBatchDetail();
            prototype.LoadTable(table, "[BatchID]={0}", DbConverter.FromInt(batchID));
            return table;
        }

        public static DbTable<TBatchDetail> LoadBy(string whereCondition, params object[] parameterValues)
        {
            DbTable<TBatchDetail> table = new DbTable<TBatchDetail>();
            TBatchDetail prototype = new TBatchDetail();
            prototype.LoadTable(table, whereCondition, parameterValues);
            return table;
        }
    }

    public class TComponentMovement: DbObject
    {
        private static DbSchema schema = null;

        public int MovementID
        {
            get { return DbConverter.ToInt(this["MovementID"]); }
            set { this["MovementID"] = DbConverter.FromInt(value); }
        }

        public int Component
        {
            get { return DbConverter.ToInt(this["Component"]); }
            set { this["Component"] = DbConverter.FromInt(value); }
        }

        public DbNullable<int> _MovementType
        {
            get { return DbConverter.ToIntNull(this["_MovementType"]); }
            set { this["_MovementType"] = DbConverter.FromIntNull(value); }
        }

        public int Quantity
        {
            get { return DbConverter.ToInt(this["Quantity"]); }
            set { this["Quantity"] = DbConverter.FromInt(value); }
        }

        public DbNullable<string> Note
        {
            get { return DbConverter.ToStringNull(this["Note"]); }
            set { this["Note"] = DbConverter.FromStringNull(value); }
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

        public string MovementType
        {
            get { return DbConverter.ToString(this["MovementType"]); }
            set { this["MovementType"] = DbConverter.FromString(value); }
        }

        public string MovementCode
        {
            get { return DbConverter.ToString(this["MovementCode"]); }
            set { this["MovementCode"] = DbConverter.FromString(value); }
        }

        protected override DbSchema GetSchema()
        {
            if (schema == null)
            {
                schema = new DbSchema("TComponentMovement");
                schema.Add("MovementID", typeof(int), "MovementID", false, true, true);
                schema.Add("Component", typeof(int), "Component", false);
                schema.Add("_MovementType", typeof(int), "_MovementType", true);
                schema.Add("Quantity", typeof(int), "Quantity", false);
                schema.Add("Note", typeof(string), "Note", true);
                schema.Add("Created", typeof(DateTime), "Created", false);
                schema.Add("CreatedBy", typeof(string), "CreatedBy", false);
                schema.Add("MovementType", typeof(string), "MovementType", false);
                schema.Add("MovementCode", typeof(string), "MovementCode", false);
            }

            return schema;
        }

        public override void LoadDefaultValues()
        {
            SqlCommand command = Session.CreateCommand();

            this["MovementID"] = DbConverter.DefaultInt();

            this["Component"] = DbConverter.DefaultInt();

            this["_MovementType"] = DBNull.Value;

            command.CommandText = "SELECT ((0))";
            this["Quantity"] = command.ExecuteScalar();

            this["Note"] = DBNull.Value;

            command.CommandText = "SELECT (getdate())";
            this["Created"] = command.ExecuteScalar();

            command.CommandText = "SELECT ([dbo].[FceUserMSSQL]())";
            this["CreatedBy"] = command.ExecuteScalar();

            this["MovementType"] = DbConverter.DefaultString();

            this["MovementCode"] = DbConverter.DefaultString();
        }

        public static TComponentMovement Load(int movementID)
        {
            TComponentMovement result = new TComponentMovement();
            result.LoadRecord(movementID);
            return result;
        }

        public static TComponentMovement CachedLoad(int movementID)
        {
            DbCache.TableKey key = new DbCache.TableKey("TComponentMovement");
            DbCache.CacheRecord record;
            key.Set(movementID);
            if (DbCache.Contains(key))
            {
                record = DbCache.GetRecord(key);
                if (!record.IsValid())
                {
                    record.Value = Load(movementID);
                    record.LastUpdate = DateTime.Now;
                    record.Valid = true;
                }
            }
            else
            {
                record = new DbCache.CacheRecord();
                record.Value = Load(movementID);
                record.LastUpdate = DateTime.Now;
                record.Valid = true;
                DbCache.SetRecord(key, record);
            }
            return (TComponentMovement)record.Value;
        }

        public static TComponentMovement Create()
        {
            TComponentMovement result = new TComponentMovement();
            result.LoadDefaultValues();
            return result;
        }

        public static DbTable<TComponentMovement> LoadAll()
        {
            DbTable<TComponentMovement> table = new DbTable<TComponentMovement>();
            TComponentMovement prototype = new TComponentMovement();
            prototype.LoadTable(table);
            return table;
        }

        public static DbTable<TComponentMovement> LoadByComponent(int component)
        {
            DbTable<TComponentMovement> table = new DbTable<TComponentMovement>();
            TComponentMovement prototype = new TComponentMovement();
            prototype.LoadTable(table, "[Component]={0}", DbConverter.FromInt(component));
            return table;
        }

        public static DbTable<TComponentMovement> LoadBy(string whereCondition, params object[] parameterValues)
        {
            DbTable<TComponentMovement> table = new DbTable<TComponentMovement>();
            TComponentMovement prototype = new TComponentMovement();
            prototype.LoadTable(table, whereCondition, parameterValues);
            return table;
        }
    }

    public class TDenniPlan: DbObject
    {
        private static DbSchema schema = null;

        public DbNullable<string> PDM_status
        {
            get { return DbConverter.ToStringNull(this["PDM status"]); }
            set { this["PDM status"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<DateTime> Plán_datum_focení
        {
            get { return DbConverter.ToDateTimeNull(this["Plán datum focení"]); }
            set { this["Plán datum focení"] = DbConverter.FromDateTimeNull(value); }
        }

        public string Číslo_komponentu
        {
            get { return DbConverter.ToString(this["Číslo komponentu"]); }
            set { this["Číslo komponentu"] = DbConverter.FromString(value); }
        }

        public DbNullable<string> BIN
        {
            get { return DbConverter.ToStringNull(this["BIN"]); }
            set { this["BIN"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> PC_na_binu
        {
            get { return DbConverter.ToStringNull(this["PC na binu"]); }
            set { this["PC na binu"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> available_for_photos
        {
            get { return DbConverter.ToStringNull(this["available for photos"]); }
            set { this["available for photos"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> reason_of_missing_photos_of_component
        {
            get { return DbConverter.ToStringNull(this["reason of missing photos of component"]); }
            set { this["reason of missing photos of component"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> PDM_substitution
        {
            get { return DbConverter.ToStringNull(this["PDM substitution"]); }
            set { this["PDM substitution"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> Reason_of_PDm_substitution
        {
            get { return DbConverter.ToStringNull(this["Reason of PDm substitution"]); }
            set { this["Reason of PDm substitution"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> Název_komponentu
        {
            get { return DbConverter.ToStringNull(this["Název komponentu"]); }
            set { this["Název komponentu"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> komponent_kategorie
        {
            get { return DbConverter.ToStringNull(this["komponent kategorie"]); }
            set { this["komponent kategorie"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> vendor_kod
        {
            get { return DbConverter.ToStringNull(this["vendor kod"]); }
            set { this["vendor kod"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> kategorie_komponentu
        {
            get { return DbConverter.ToStringNull(this["kategorie komponentu"]); }
            set { this["kategorie komponentu"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<DateTime> nafoceno_dne
        {
            get { return DbConverter.ToDateTimeNull(this["nafoceno dne"]); }
            set { this["nafoceno dne"] = DbConverter.FromDateTimeNull(value); }
        }

        public DbNullable<string> week_nafocení
        {
            get { return DbConverter.ToStringNull(this["week nafocení"]); }
            set { this["week nafocení"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> nafotil
        {
            get { return DbConverter.ToStringNull(this["nafotil"]); }
            set { this["nafotil"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> oprava_fotek
        {
            get { return DbConverter.ToStringNull(this["oprava fotek"]); }
            set { this["oprava fotek"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> week_opravy
        {
            get { return DbConverter.ToStringNull(this["week opravy"]); }
            set { this["week opravy"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> kontrola_fotek
        {
            get { return DbConverter.ToStringNull(this["kontrola fotek"]); }
            set { this["kontrola fotek"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> počet_částí_komp
        {
            get { return DbConverter.ToStringNull(this["počet částí komp"]); }
            set { this["počet částí komp"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<double> ComPics
        {
            get { return DbConverter.ToDoubleNull(this["ComPics"]); }
            set { this["ComPics"] = DbConverter.FromDoubleNull(value); }
        }

        public DbNullable<double> pohled_fotek_C
        {
            get { return DbConverter.ToDoubleNull(this["pohled fotek C"]); }
            set { this["pohled fotek C"] = DbConverter.FromDoubleNull(value); }
        }

        public DbNullable<double> pohled_fotek_T
        {
            get { return DbConverter.ToDoubleNull(this["pohled fotek T"]); }
            set { this["pohled fotek T"] = DbConverter.FromDoubleNull(value); }
        }

        public DbNullable<string> pohled_fotek_TF
        {
            get { return DbConverter.ToStringNull(this["pohled fotek TF"]); }
            set { this["pohled fotek TF"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> pohled_fotek_speciální
        {
            get { return DbConverter.ToStringNull(this["pohled fotek speciální"]); }
            set { this["pohled fotek speciální"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> Speciální_poznámky
        {
            get { return DbConverter.ToStringNull(this["Speciální poznámky"]); }
            set { this["Speciální poznámky"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> PDM_comments
        {
            get { return DbConverter.ToStringNull(this["PDM comments"]); }
            set { this["PDM comments"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> Fyzická_kontrola_komponentu_na_BINu
        {
            get { return DbConverter.ToStringNull(this["Fyzická kontrola komponentu na BINu"]); }
            set { this["Fyzická kontrola komponentu na BINu"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> Vzorový_komponent_na_BINu
        {
            get { return DbConverter.ToStringNull(this["Vzorový komponent na BINu"]); }
            set { this["Vzorový komponent na BINu"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> Master_List
        {
            get { return DbConverter.ToStringNull(this["Master List"]); }
            set { this["Master List"] = DbConverter.FromStringNull(value); }
        }

        protected override DbSchema GetSchema()
        {
            if (schema == null)
            {
                schema = new DbSchema("TDenniPlan");
                schema.Add("PDM status", typeof(string), "PDM status", true);
                schema.Add("Plán datum focení", typeof(DateTime), "Plán datum focení", true);
                schema.Add("Číslo komponentu", typeof(string), "Číslo komponentu", false, true, false);
                schema.Add("BIN", typeof(string), "BIN", true);
                schema.Add("PC na binu", typeof(string), "PC na binu", true);
                schema.Add("available for photos", typeof(string), "available for photos", true);
                schema.Add("reason of missing photos of component", typeof(string), "reason of missing photos of component", true);
                schema.Add("PDM substitution", typeof(string), "PDM substitution", true);
                schema.Add("Reason of PDm substitution", typeof(string), "Reason of PDm substitution", true);
                schema.Add("Název komponentu", typeof(string), "Název komponentu", true);
                schema.Add("komponent kategorie", typeof(string), "komponent kategorie", true);
                schema.Add("vendor kod", typeof(string), "vendor kod", true);
                schema.Add("kategorie komponentu", typeof(string), "kategorie komponentu", true);
                schema.Add("nafoceno dne", typeof(DateTime), "nafoceno dne", true);
                schema.Add("week nafocení", typeof(string), "week nafocení", true);
                schema.Add("nafotil", typeof(string), "nafotil", true);
                schema.Add("oprava fotek", typeof(string), "oprava fotek", true);
                schema.Add("week opravy", typeof(string), "week opravy", true);
                schema.Add("kontrola fotek", typeof(string), "kontrola fotek", true);
                schema.Add("počet částí komp", typeof(string), "počet částí komp", true);
                schema.Add("ComPics", typeof(double), "ComPics", true);
                schema.Add("pohled fotek C", typeof(double), "pohled fotek C", true);
                schema.Add("pohled fotek T", typeof(double), "pohled fotek T", true);
                schema.Add("pohled fotek TF", typeof(string), "pohled fotek TF", true);
                schema.Add("pohled fotek speciální", typeof(string), "pohled fotek speciální", true);
                schema.Add("Speciální poznámky", typeof(string), "Speciální poznámky", true);
                schema.Add("PDM comments", typeof(string), "PDM comments", true);
                schema.Add("Fyzická kontrola komponentu na BINu", typeof(string), "Fyzická kontrola komponentu na BINu", true);
                schema.Add("Vzorový komponent na BINu", typeof(string), "Vzorový komponent na BINu", true);
                schema.Add("Master List", typeof(string), "Master List", true);
            }

            return schema;
        }

        public override void LoadDefaultValues()
        {
            SqlCommand command = Session.CreateCommand();

            this["PDM status"] = DBNull.Value;

            this["Plán datum focení"] = DBNull.Value;

            this["Číslo komponentu"] = DbConverter.DefaultString();

            this["BIN"] = DBNull.Value;

            this["PC na binu"] = DBNull.Value;

            this["available for photos"] = DBNull.Value;

            this["reason of missing photos of component"] = DBNull.Value;

            this["PDM substitution"] = DBNull.Value;

            this["Reason of PDm substitution"] = DBNull.Value;

            this["Název komponentu"] = DBNull.Value;

            this["komponent kategorie"] = DBNull.Value;

            this["vendor kod"] = DBNull.Value;

            this["kategorie komponentu"] = DBNull.Value;

            this["nafoceno dne"] = DBNull.Value;

            this["week nafocení"] = DBNull.Value;

            this["nafotil"] = DBNull.Value;

            this["oprava fotek"] = DBNull.Value;

            this["week opravy"] = DBNull.Value;

            this["kontrola fotek"] = DBNull.Value;

            this["počet částí komp"] = DBNull.Value;

            this["ComPics"] = DBNull.Value;

            this["pohled fotek C"] = DBNull.Value;

            this["pohled fotek T"] = DBNull.Value;

            this["pohled fotek TF"] = DBNull.Value;

            this["pohled fotek speciální"] = DBNull.Value;

            this["Speciální poznámky"] = DBNull.Value;

            this["PDM comments"] = DBNull.Value;

            this["Fyzická kontrola komponentu na BINu"] = DBNull.Value;

            this["Vzorový komponent na BINu"] = DBNull.Value;

            this["Master List"] = DBNull.Value;
        }

        public static TDenniPlan Load(string Číslo_komponentu)
        {
            TDenniPlan result = new TDenniPlan();
            result.LoadRecord(Číslo_komponentu);
            return result;
        }

        public static TDenniPlan CachedLoad(string Číslo_komponentu)
        {
            DbCache.TableKey key = new DbCache.TableKey("TDenniPlan");
            DbCache.CacheRecord record;
            key.Set(Číslo_komponentu);
            if (DbCache.Contains(key))
            {
                record = DbCache.GetRecord(key);
                if (!record.IsValid())
                {
                    record.Value = Load(Číslo_komponentu);
                    record.LastUpdate = DateTime.Now;
                    record.Valid = true;
                }
            }
            else
            {
                record = new DbCache.CacheRecord();
                record.Value = Load(Číslo_komponentu);
                record.LastUpdate = DateTime.Now;
                record.Valid = true;
                DbCache.SetRecord(key, record);
            }
            return (TDenniPlan)record.Value;
        }

        public static TDenniPlan Create()
        {
            TDenniPlan result = new TDenniPlan();
            result.LoadDefaultValues();
            return result;
        }

        public static DbTable<TDenniPlan> LoadAll()
        {
            DbTable<TDenniPlan> table = new DbTable<TDenniPlan>();
            TDenniPlan prototype = new TDenniPlan();
            prototype.LoadTable(table);
            return table;
        }

        public static DbTable<TDenniPlan> LoadBy(string whereCondition, params object[] parameterValues)
        {
            DbTable<TDenniPlan> table = new DbTable<TDenniPlan>();
            TDenniPlan prototype = new TDenniPlan();
            prototype.LoadTable(table, whereCondition, parameterValues);
            return table;
        }
    }

    public class TKomponentKategorie: DbObject
    {
        private static DbSchema schema = null;

        public int IDKomponentKategorie
        {
            get { return DbConverter.ToInt(this["IDKomponentKategorie"]); }
            set { this["IDKomponentKategorie"] = DbConverter.FromInt(value); }
        }

        public DbNullable<string> KomponentKategorieName
        {
            get { return DbConverter.ToStringNull(this["KomponentKategorieName"]); }
            set { this["KomponentKategorieName"] = DbConverter.FromStringNull(value); }
        }

        protected override DbSchema GetSchema()
        {
            if (schema == null)
            {
                schema = new DbSchema("TKomponentKategorie");
                schema.Add("IDKomponentKategorie", typeof(int), "IDKomponentKategorie", false, true, true);
                schema.Add("KomponentKategorieName", typeof(string), "KomponentKategorieName", true);
            }

            return schema;
        }

        public override void LoadDefaultValues()
        {
            SqlCommand command = Session.CreateCommand();

            this["IDKomponentKategorie"] = DbConverter.DefaultInt();

            this["KomponentKategorieName"] = DBNull.Value;
        }

        public static TKomponentKategorie Load(int iDKomponentKategorie)
        {
            TKomponentKategorie result = new TKomponentKategorie();
            result.LoadRecord(iDKomponentKategorie);
            return result;
        }

        public static TKomponentKategorie CachedLoad(int iDKomponentKategorie)
        {
            DbCache.TableKey key = new DbCache.TableKey("TKomponentKategorie");
            DbCache.CacheRecord record;
            key.Set(iDKomponentKategorie);
            if (DbCache.Contains(key))
            {
                record = DbCache.GetRecord(key);
                if (!record.IsValid())
                {
                    record.Value = Load(iDKomponentKategorie);
                    record.LastUpdate = DateTime.Now;
                    record.Valid = true;
                }
            }
            else
            {
                record = new DbCache.CacheRecord();
                record.Value = Load(iDKomponentKategorie);
                record.LastUpdate = DateTime.Now;
                record.Valid = true;
                DbCache.SetRecord(key, record);
            }
            return (TKomponentKategorie)record.Value;
        }

        public static TKomponentKategorie Create()
        {
            TKomponentKategorie result = new TKomponentKategorie();
            result.LoadDefaultValues();
            return result;
        }

        public static DbTable<TKomponentKategorie> LoadAll()
        {
            DbTable<TKomponentKategorie> table = new DbTable<TKomponentKategorie>();
            TKomponentKategorie prototype = new TKomponentKategorie();
            prototype.LoadTable(table);
            return table;
        }

        public static DbTable<TKomponentKategorie> LoadBy(string whereCondition, params object[] parameterValues)
        {
            DbTable<TKomponentKategorie> table = new DbTable<TKomponentKategorie>();
            TKomponentKategorie prototype = new TKomponentKategorie();
            prototype.LoadTable(table, whereCondition, parameterValues);
            return table;
        }
    }

    public class TPersonResponsiblePhoto: DbObject
    {
        private static DbSchema schema = null;

        public int IDResponsiblePhoto
        {
            get { return DbConverter.ToInt(this["IDResponsiblePhoto"]); }
            set { this["IDResponsiblePhoto"] = DbConverter.FromInt(value); }
        }

        public DbNullable<string> ResponsiblePhotoName
        {
            get { return DbConverter.ToStringNull(this["ResponsiblePhotoName"]); }
            set { this["ResponsiblePhotoName"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> ResponsiblePhotoSurname
        {
            get { return DbConverter.ToStringNull(this["ResponsiblePhotoSurname"]); }
            set { this["ResponsiblePhotoSurname"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> ResponsiblePhotoCode
        {
            get { return DbConverter.ToStringNull(this["ResponsiblePhotoCode"]); }
            set { this["ResponsiblePhotoCode"] = DbConverter.FromStringNull(value); }
        }

        protected override DbSchema GetSchema()
        {
            if (schema == null)
            {
                schema = new DbSchema("TPersonResponsiblePhoto");
                schema.Add("IDResponsiblePhoto", typeof(int), "IDResponsiblePhoto", false, true, true);
                schema.Add("ResponsiblePhotoName", typeof(string), "ResponsiblePhotoName", true);
                schema.Add("ResponsiblePhotoSurname", typeof(string), "ResponsiblePhotoSurname", true);
                schema.Add("ResponsiblePhotoCode", typeof(string), "ResponsiblePhotoCode", true);
            }

            return schema;
        }

        public override void LoadDefaultValues()
        {
            SqlCommand command = Session.CreateCommand();

            this["IDResponsiblePhoto"] = DbConverter.DefaultInt();

            this["ResponsiblePhotoName"] = DBNull.Value;

            this["ResponsiblePhotoSurname"] = DBNull.Value;

            this["ResponsiblePhotoCode"] = DBNull.Value;
        }

        public static TPersonResponsiblePhoto Load(int iDResponsiblePhoto)
        {
            TPersonResponsiblePhoto result = new TPersonResponsiblePhoto();
            result.LoadRecord(iDResponsiblePhoto);
            return result;
        }

        public static TPersonResponsiblePhoto CachedLoad(int iDResponsiblePhoto)
        {
            DbCache.TableKey key = new DbCache.TableKey("TPersonResponsiblePhoto");
            DbCache.CacheRecord record;
            key.Set(iDResponsiblePhoto);
            if (DbCache.Contains(key))
            {
                record = DbCache.GetRecord(key);
                if (!record.IsValid())
                {
                    record.Value = Load(iDResponsiblePhoto);
                    record.LastUpdate = DateTime.Now;
                    record.Valid = true;
                }
            }
            else
            {
                record = new DbCache.CacheRecord();
                record.Value = Load(iDResponsiblePhoto);
                record.LastUpdate = DateTime.Now;
                record.Valid = true;
                DbCache.SetRecord(key, record);
            }
            return (TPersonResponsiblePhoto)record.Value;
        }

        public static TPersonResponsiblePhoto Create()
        {
            TPersonResponsiblePhoto result = new TPersonResponsiblePhoto();
            result.LoadDefaultValues();
            return result;
        }

        public static DbTable<TPersonResponsiblePhoto> LoadAll()
        {
            DbTable<TPersonResponsiblePhoto> table = new DbTable<TPersonResponsiblePhoto>();
            TPersonResponsiblePhoto prototype = new TPersonResponsiblePhoto();
            prototype.LoadTable(table);
            return table;
        }

        public static DbTable<TPersonResponsiblePhoto> LoadBy(string whereCondition, params object[] parameterValues)
        {
            DbTable<TPersonResponsiblePhoto> table = new DbTable<TPersonResponsiblePhoto>();
            TPersonResponsiblePhoto prototype = new TPersonResponsiblePhoto();
            prototype.LoadTable(table, whereCondition, parameterValues);
            return table;
        }
    }

    public class TParameters: DbObject
    {
        private static DbSchema schema = null;

        public int ID
        {
            get { return DbConverter.ToInt(this["ID"]); }
            set { this["ID"] = DbConverter.FromInt(value); }
        }

        public DbNullable<string> ExcelTemp
        {
            get { return DbConverter.ToStringNull(this["ExcelTemp"]); }
            set { this["ExcelTemp"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<decimal> HmotnostKoef
        {
            get { return DbConverter.ToDecimalNull(this["HmotnostKoef"]); }
            set { this["HmotnostKoef"] = DbConverter.FromDecimalNull(value); }
        }

        public DbNullable<string> AttachFolder
        {
            get { return DbConverter.ToStringNull(this["AttachFolder"]); }
            set { this["AttachFolder"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<decimal> IFU
        {
            get { return DbConverter.ToDecimalNull(this["IFU"]); }
            set { this["IFU"] = DbConverter.FromDecimalNull(value); }
        }

        public DbNullable<decimal> TimeKoef
        {
            get { return DbConverter.ToDecimalNull(this["TimeKoef"]); }
            set { this["TimeKoef"] = DbConverter.FromDecimalNull(value); }
        }

        public DbNullable<string> PathMostForm
        {
            get { return DbConverter.ToStringNull(this["PathMostForm"]); }
            set { this["PathMostForm"] = DbConverter.FromStringNull(value); }
        }

        protected override DbSchema GetSchema()
        {
            if (schema == null)
            {
                schema = new DbSchema("TParameters");
                schema.Add("ID", typeof(int), "ID", false, true, false);
                schema.Add("ExcelTemp", typeof(string), "ExcelTemp", true);
                schema.Add("HmotnostKoef", typeof(decimal), "HmotnostKoef", true);
                schema.Add("AttachFolder", typeof(string), "AttachFolder", true);
                schema.Add("IFU", typeof(decimal), "IFU", true);
                schema.Add("TimeKoef", typeof(decimal), "TimeKoef", true);
                schema.Add("PathMostForm", typeof(string), "PathMostForm", true);
            }

            return schema;
        }

        public override void LoadDefaultValues()
        {
            SqlCommand command = Session.CreateCommand();

            this["ID"] = DbConverter.DefaultInt();

            this["ExcelTemp"] = DBNull.Value;

            this["HmotnostKoef"] = DBNull.Value;

            this["AttachFolder"] = DBNull.Value;

            this["IFU"] = DBNull.Value;

            this["TimeKoef"] = DBNull.Value;

            this["PathMostForm"] = DBNull.Value;
        }

        public static TParameters Load(int iD)
        {
            TParameters result = new TParameters();
            result.LoadRecord(iD);
            return result;
        }

        public static TParameters CachedLoad(int iD)
        {
            DbCache.TableKey key = new DbCache.TableKey("TParameters");
            DbCache.CacheRecord record;
            key.Set(iD);
            if (DbCache.Contains(key))
            {
                record = DbCache.GetRecord(key);
                if (!record.IsValid())
                {
                    record.Value = Load(iD);
                    record.LastUpdate = DateTime.Now;
                    record.Valid = true;
                }
            }
            else
            {
                record = new DbCache.CacheRecord();
                record.Value = Load(iD);
                record.LastUpdate = DateTime.Now;
                record.Valid = true;
                DbCache.SetRecord(key, record);
            }
            return (TParameters)record.Value;
        }

        public static TParameters Create()
        {
            TParameters result = new TParameters();
            result.LoadDefaultValues();
            return result;
        }

        public static DbTable<TParameters> LoadAll()
        {
            DbTable<TParameters> table = new DbTable<TParameters>();
            TParameters prototype = new TParameters();
            prototype.LoadTable(table);
            return table;
        }

        public static DbTable<TParameters> LoadBy(string whereCondition, params object[] parameterValues)
        {
            DbTable<TParameters> table = new DbTable<TParameters>();
            TParameters prototype = new TParameters();
            prototype.LoadTable(table, whereCondition, parameterValues);
            return table;
        }
    }

    public class TComplaint: DbObject
    {
        private static DbSchema schema = null;

        public int IDComplaint
        {
            get { return DbConverter.ToInt(this["IDComplaint"]); }
            set { this["IDComplaint"] = DbConverter.FromInt(value); }
        }

        public DbNullable<int> Notification
        {
            get { return DbConverter.ToIntNull(this["Notification"]); }
            set { this["Notification"] = DbConverter.FromIntNull(value); }
        }

        public DbNullable<string> DescriptionShort
        {
            get { return DbConverter.ToStringNull(this["DescriptionShort"]); }
            set { this["DescriptionShort"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> DescriptionLong
        {
            get { return DbConverter.ToStringNull(this["DescriptionLong"]); }
            set { this["DescriptionLong"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> CustomerNo
        {
            get { return DbConverter.ToStringNull(this["CustomerNo"]); }
            set { this["CustomerNo"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> CCoordinatorCode
        {
            get { return DbConverter.ToStringNull(this["CCoordinatorCode"]); }
            set { this["CCoordinatorCode"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> CountryCode
        {
            get { return DbConverter.ToStringNull(this["CountryCode"]); }
            set { this["CountryCode"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<DateTime> Created
        {
            get { return DbConverter.ToDateTimeNull(this["Created"]); }
            set { this["Created"] = DbConverter.FromDateTimeNull(value); }
        }

        public DbNullable<DateTime> RequiredDate
        {
            get { return DbConverter.ToDateTimeNull(this["RequiredDate"]); }
            set { this["RequiredDate"] = DbConverter.FromDateTimeNull(value); }
        }

        public DbNullable<string> Plant
        {
            get { return DbConverter.ToStringNull(this["Plant"]); }
            set { this["Plant"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> Material
        {
            get { return DbConverter.ToStringNull(this["Material"]); }
            set { this["Material"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> LOT
        {
            get { return DbConverter.ToStringNull(this["LOT"]); }
            set { this["LOT"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<int> TypeComplaintID
        {
            get { return DbConverter.ToIntNull(this["TypeComplaintID"]); }
            set { this["TypeComplaintID"] = DbConverter.FromIntNull(value); }
        }

        public DbNullable<string> TypeComplaintSAP
        {
            get { return DbConverter.ToStringNull(this["TypeComplaintSAP"]); }
            set { this["TypeComplaintSAP"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<bool> KaDefect
        {
            get { return DbConverter.ToBoolNull(this["KaDefect"]); }
            set { this["KaDefect"] = DbConverter.FromBoolNull(value); }
        }

        public DbNullable<bool> Penalty
        {
            get { return DbConverter.ToBoolNull(this["Penalty"]); }
            set { this["Penalty"] = DbConverter.FromBoolNull(value); }
        }

        public DbNullable<int> TypeDefectID
        {
            get { return DbConverter.ToIntNull(this["TypeDefectID"]); }
            set { this["TypeDefectID"] = DbConverter.FromIntNull(value); }
        }

        public DbNullable<string> OrderNo
        {
            get { return DbConverter.ToStringNull(this["OrderNo"]); }
            set { this["OrderNo"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<int> BatchID
        {
            get { return DbConverter.ToIntNull(this["BatchID"]); }
            set { this["BatchID"] = DbConverter.FromIntNull(value); }
        }

        public DbNullable<string> Contakt
        {
            get { return DbConverter.ToStringNull(this["Contakt"]); }
            set { this["Contakt"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> Vendor
        {
            get { return DbConverter.ToStringNull(this["Vendor"]); }
            set { this["Vendor"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<int> Quantity
        {
            get { return DbConverter.ToIntNull(this["Quantity"]); }
            set { this["Quantity"] = DbConverter.FromIntNull(value); }
        }

        public DbNullable<string> ChfComment
        {
            get { return DbConverter.ToStringNull(this["ChfComment"]); }
            set { this["ChfComment"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> AffectComponent
        {
            get { return DbConverter.ToStringNull(this["AffectComponent"]); }
            set { this["AffectComponent"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<int> ZVNotification
        {
            get { return DbConverter.ToIntNull(this["ZVNotification"]); }
            set { this["ZVNotification"] = DbConverter.FromIntNull(value); }
        }

        public DbNullable<bool> ZVNotificCheckBox
        {
            get { return DbConverter.ToBoolNull(this["ZVNotificCheckBox"]); }
            set { this["ZVNotificCheckBox"] = DbConverter.FromBoolNull(value); }
        }

        public DbNullable<int> SamplesID
        {
            get { return DbConverter.ToIntNull(this["SamplesID"]); }
            set { this["SamplesID"] = DbConverter.FromIntNull(value); }
        }

        public DbNullable<DateTime> DateSamples
        {
            get { return DbConverter.ToDateTimeNull(this["DateSamples"]); }
            set { this["DateSamples"] = DbConverter.FromDateTimeNull(value); }
        }

        public DbNullable<DateTime> DateFinish
        {
            get { return DbConverter.ToDateTimeNull(this["DateFinish"]); }
            set { this["DateFinish"] = DbConverter.FromDateTimeNull(value); }
        }

        public DbNullable<int> DayHandledOther
        {
            get { return DbConverter.ToIntNull(this["DayHandledOther"]); }
            set { this["DayHandledOther"] = DbConverter.FromIntNull(value); }
        }

        public DbNullable<int> PersonResponsibleID
        {
            get { return DbConverter.ToIntNull(this["PersonResponsibleID"]); }
            set { this["PersonResponsibleID"] = DbConverter.FromIntNull(value); }
        }

        public DbNullable<int> StatusID
        {
            get { return DbConverter.ToIntNull(this["StatusID"]); }
            set { this["StatusID"] = DbConverter.FromIntNull(value); }
        }

        public DbNullable<bool> Closed
        {
            get { return DbConverter.ToBoolNull(this["Closed"]); }
            set { this["Closed"] = DbConverter.FromBoolNull(value); }
        }

        public DbNullable<DateTime> CreatedDate
        {
            get { return DbConverter.ToDateTimeNull(this["CreatedDate"]); }
            set { this["CreatedDate"] = DbConverter.FromDateTimeNull(value); }
        }

        public DbNullable<string> CreatedBy
        {
            get { return DbConverter.ToStringNull(this["CreatedBy"]); }
            set { this["CreatedBy"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> ChfCommentNew
        {
            get { return DbConverter.ToStringNull(this["ChfCommentNew"]); }
            set { this["ChfCommentNew"] = DbConverter.FromStringNull(value); }
        }

        protected override DbSchema GetSchema()
        {
            if (schema == null)
            {
                schema = new DbSchema("TComplaint");
                schema.Add("IDComplaint", typeof(int), "IDComplaint", false, true, true);
                schema.Add("Notification", typeof(int), "Notification", true);
                schema.Add("DescriptionShort", typeof(string), "DescriptionShort", true);
                schema.Add("DescriptionLong", typeof(string), "DescriptionLong", true);
                schema.Add("CustomerNo", typeof(string), "CustomerNo", true);
                schema.Add("CCoordinatorCode", typeof(string), "CCoordinatorCode", true);
                schema.Add("CountryCode", typeof(string), "CountryCode", true);
                schema.Add("Created", typeof(DateTime), "Created", true);
                schema.Add("RequiredDate", typeof(DateTime), "RequiredDate", true);
                schema.Add("Plant", typeof(string), "Plant", true);
                schema.Add("Material", typeof(string), "Material", true);
                schema.Add("LOT", typeof(string), "LOT", true);
                schema.Add("TypeComplaintID", typeof(int), "TypeComplaintID", true);
                schema.Add("TypeComplaintSAP", typeof(string), "TypeComplaintSAP", true);
                schema.Add("KaDefect", typeof(bool), "KaDefect", true);
                schema.Add("Penalty", typeof(bool), "Penalty", true);
                schema.Add("TypeDefectID", typeof(int), "TypeDefectID", true);
                schema.Add("OrderNo", typeof(string), "OrderNo", true);
                schema.Add("BatchID", typeof(int), "BatchID", true);
                schema.Add("Contakt", typeof(string), "Contakt", true);
                schema.Add("Vendor", typeof(string), "Vendor", true);
                schema.Add("Quantity", typeof(int), "Quantity", true);
                schema.Add("ChfComment", typeof(string), "ChfComment", true);
                schema.Add("AffectComponent", typeof(string), "AffectComponent", true);
                schema.Add("ZVNotification", typeof(int), "ZVNotification", true);
                schema.Add("ZVNotificCheckBox", typeof(bool), "ZVNotificCheckBox", true);
                schema.Add("SamplesID", typeof(int), "SamplesID", true);
                schema.Add("DateSamples", typeof(DateTime), "DateSamples", true);
                schema.Add("DateFinish", typeof(DateTime), "DateFinish", true);
                schema.Add("DayHandledOther", typeof(int), "DayHandledOther", true);
                schema.Add("PersonResponsibleID", typeof(int), "PersonResponsibleID", true);
                schema.Add("StatusID", typeof(int), "StatusID", true);
                schema.Add("Closed", typeof(bool), "Closed", true);
                schema.Add("CreatedDate", typeof(DateTime), "CreatedDate", true);
                schema.Add("CreatedBy", typeof(string), "CreatedBy", true);
                schema.Add("ChfCommentNew", typeof(string), "ChfCommentNew", true);
            }

            return schema;
        }

        public override void LoadDefaultValues()
        {
            SqlCommand command = Session.CreateCommand();

            this["IDComplaint"] = DbConverter.DefaultInt();

            this["Notification"] = DBNull.Value;

            this["DescriptionShort"] = DBNull.Value;

            this["DescriptionLong"] = DBNull.Value;

            this["CustomerNo"] = DBNull.Value;

            this["CCoordinatorCode"] = DBNull.Value;

            this["CountryCode"] = DBNull.Value;

            this["Created"] = DBNull.Value;

            this["RequiredDate"] = DBNull.Value;

            this["Plant"] = DBNull.Value;

            this["Material"] = DBNull.Value;

            this["LOT"] = DBNull.Value;

            this["TypeComplaintID"] = DBNull.Value;

            this["TypeComplaintSAP"] = DBNull.Value;

            this["KaDefect"] = DBNull.Value;

            this["Penalty"] = DBNull.Value;

            this["TypeDefectID"] = DBNull.Value;

            this["OrderNo"] = DBNull.Value;

            this["BatchID"] = DBNull.Value;

            this["Contakt"] = DBNull.Value;

            this["Vendor"] = DBNull.Value;

            this["Quantity"] = DBNull.Value;

            this["ChfComment"] = DBNull.Value;

            this["AffectComponent"] = DBNull.Value;

            this["ZVNotification"] = DBNull.Value;

            this["ZVNotificCheckBox"] = DBNull.Value;

            this["SamplesID"] = DBNull.Value;

            this["DateSamples"] = DBNull.Value;

            this["DateFinish"] = DBNull.Value;

            this["DayHandledOther"] = DBNull.Value;

            this["PersonResponsibleID"] = DBNull.Value;

            this["StatusID"] = DBNull.Value;

            command.CommandText = "SELECT (0)";
            this["Closed"] = command.ExecuteScalar();

            command.CommandText = "SELECT (getdate())";
            this["CreatedDate"] = command.ExecuteScalar();

            command.CommandText = "SELECT ([dbo].[FceUserMSSQL]())";
            this["CreatedBy"] = command.ExecuteScalar();

            this["ChfCommentNew"] = DBNull.Value;
        }

        public static TComplaint Load(int iDComplaint)
        {
            TComplaint result = new TComplaint();
            result.LoadRecord(iDComplaint);
            return result;
        }

        public static TComplaint CachedLoad(int iDComplaint)
        {
            DbCache.TableKey key = new DbCache.TableKey("TComplaint");
            DbCache.CacheRecord record;
            key.Set(iDComplaint);
            if (DbCache.Contains(key))
            {
                record = DbCache.GetRecord(key);
                if (!record.IsValid())
                {
                    record.Value = Load(iDComplaint);
                    record.LastUpdate = DateTime.Now;
                    record.Valid = true;
                }
            }
            else
            {
                record = new DbCache.CacheRecord();
                record.Value = Load(iDComplaint);
                record.LastUpdate = DateTime.Now;
                record.Valid = true;
                DbCache.SetRecord(key, record);
            }
            return (TComplaint)record.Value;
        }

        public static TComplaint Create()
        {
            TComplaint result = new TComplaint();
            result.LoadDefaultValues();
            return result;
        }

        public static DbTable<TComplaint> LoadAll()
        {
            DbTable<TComplaint> table = new DbTable<TComplaint>();
            TComplaint prototype = new TComplaint();
            prototype.LoadTable(table);
            return table;
        }

        public static DbTable<TComplaint> LoadByCustomerNo(DbNullable<string> customerNo)
        {
            DbTable<TComplaint> table = new DbTable<TComplaint>();
            TComplaint prototype = new TComplaint();
            prototype.LoadTable(table, "[CustomerNo]={0}", DbConverter.FromStringNull(customerNo));
            return table;
        }

        public static DbTable<TComplaint> LoadByCCoordinatorCode(DbNullable<string> cCoordinatorCode)
        {
            DbTable<TComplaint> table = new DbTable<TComplaint>();
            TComplaint prototype = new TComplaint();
            prototype.LoadTable(table, "[CCoordinatorCode]={0}", DbConverter.FromStringNull(cCoordinatorCode));
            return table;
        }

        public static DbTable<TComplaint> LoadByCountryCode(DbNullable<string> countryCode)
        {
            DbTable<TComplaint> table = new DbTable<TComplaint>();
            TComplaint prototype = new TComplaint();
            prototype.LoadTable(table, "[CountryCode]={0}", DbConverter.FromStringNull(countryCode));
            return table;
        }

        public static DbTable<TComplaint> LoadByPlant(DbNullable<string> plant)
        {
            DbTable<TComplaint> table = new DbTable<TComplaint>();
            TComplaint prototype = new TComplaint();
            prototype.LoadTable(table, "[Plant]={0}", DbConverter.FromStringNull(plant));
            return table;
        }

        public static DbTable<TComplaint> LoadByTypeComplaintID(DbNullable<int> typeComplaintID)
        {
            DbTable<TComplaint> table = new DbTable<TComplaint>();
            TComplaint prototype = new TComplaint();
            prototype.LoadTable(table, "[TypeComplaintID]={0}", DbConverter.FromIntNull(typeComplaintID));
            return table;
        }

        public static DbTable<TComplaint> LoadByTypeDefectID(DbNullable<int> typeDefectID)
        {
            DbTable<TComplaint> table = new DbTable<TComplaint>();
            TComplaint prototype = new TComplaint();
            prototype.LoadTable(table, "[TypeDefectID]={0}", DbConverter.FromIntNull(typeDefectID));
            return table;
        }

        public static DbTable<TComplaint> LoadBySamplesID(DbNullable<int> samplesID)
        {
            DbTable<TComplaint> table = new DbTable<TComplaint>();
            TComplaint prototype = new TComplaint();
            prototype.LoadTable(table, "[SamplesID]={0}", DbConverter.FromIntNull(samplesID));
            return table;
        }

        public static DbTable<TComplaint> LoadByPersonResponsibleID(DbNullable<int> personResponsibleID)
        {
            DbTable<TComplaint> table = new DbTable<TComplaint>();
            TComplaint prototype = new TComplaint();
            prototype.LoadTable(table, "[PersonResponsibleID]={0}", DbConverter.FromIntNull(personResponsibleID));
            return table;
        }

        public static DbTable<TComplaint> LoadByStatusID(DbNullable<int> statusID)
        {
            DbTable<TComplaint> table = new DbTable<TComplaint>();
            TComplaint prototype = new TComplaint();
            prototype.LoadTable(table, "[StatusID]={0}", DbConverter.FromIntNull(statusID));
            return table;
        }

        public static DbTable<TComplaint> LoadBy(string whereCondition, params object[] parameterValues)
        {
            DbTable<TComplaint> table = new DbTable<TComplaint>();
            TComplaint prototype = new TComplaint();
            prototype.LoadTable(table, whereCondition, parameterValues);
            return table;
        }
    }

    public class TAvailability: DbObject
    {
        private static DbSchema schema = null;

        public int IDAvailability
        {
            get { return DbConverter.ToInt(this["IDAvailability"]); }
            set { this["IDAvailability"] = DbConverter.FromInt(value); }
        }

        public DbNullable<string> AvailabilityName
        {
            get { return DbConverter.ToStringNull(this["AvailabilityName"]); }
            set { this["AvailabilityName"] = DbConverter.FromStringNull(value); }
        }

        protected override DbSchema GetSchema()
        {
            if (schema == null)
            {
                schema = new DbSchema("TAvailability");
                schema.Add("IDAvailability", typeof(int), "IDAvailability", false, true, true);
                schema.Add("AvailabilityName", typeof(string), "AvailabilityName", true);
            }

            return schema;
        }

        public override void LoadDefaultValues()
        {
            SqlCommand command = Session.CreateCommand();

            this["IDAvailability"] = DbConverter.DefaultInt();

            this["AvailabilityName"] = DBNull.Value;
        }

        public static TAvailability Load(int iDAvailability)
        {
            TAvailability result = new TAvailability();
            result.LoadRecord(iDAvailability);
            return result;
        }

        public static TAvailability CachedLoad(int iDAvailability)
        {
            DbCache.TableKey key = new DbCache.TableKey("TAvailability");
            DbCache.CacheRecord record;
            key.Set(iDAvailability);
            if (DbCache.Contains(key))
            {
                record = DbCache.GetRecord(key);
                if (!record.IsValid())
                {
                    record.Value = Load(iDAvailability);
                    record.LastUpdate = DateTime.Now;
                    record.Valid = true;
                }
            }
            else
            {
                record = new DbCache.CacheRecord();
                record.Value = Load(iDAvailability);
                record.LastUpdate = DateTime.Now;
                record.Valid = true;
                DbCache.SetRecord(key, record);
            }
            return (TAvailability)record.Value;
        }

        public static TAvailability Create()
        {
            TAvailability result = new TAvailability();
            result.LoadDefaultValues();
            return result;
        }

        public static DbTable<TAvailability> LoadAll()
        {
            DbTable<TAvailability> table = new DbTable<TAvailability>();
            TAvailability prototype = new TAvailability();
            prototype.LoadTable(table);
            return table;
        }

        public static DbTable<TAvailability> LoadBy(string whereCondition, params object[] parameterValues)
        {
            DbTable<TAvailability> table = new DbTable<TAvailability>();
            TAvailability prototype = new TAvailability();
            prototype.LoadTable(table, whereCondition, parameterValues);
            return table;
        }
    }

    public class TMasterListTmp: DbObject
    {
        private static DbSchema schema = null;

        public DbNullable<string> KarvinaCode
        {
            get { return DbConverter.ToStringNull(this["KarvinaCode"]); }
            set { this["KarvinaCode"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> Category
        {
            get { return DbConverter.ToStringNull(this["Category"]); }
            set { this["Category"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> pdmStatus
        {
            get { return DbConverter.ToStringNull(this["pdmStatus"]); }
            set { this["pdmStatus"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> VendorName
        {
            get { return DbConverter.ToStringNull(this["VendorName"]); }
            set { this["VendorName"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> VendorMatNo
        {
            get { return DbConverter.ToStringNull(this["VendorMatNo"]); }
            set { this["VendorMatNo"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> VendorCode
        {
            get { return DbConverter.ToStringNull(this["VendorCode"]); }
            set { this["VendorCode"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> Description
        {
            get { return DbConverter.ToStringNull(this["Description"]); }
            set { this["Description"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> ConvertedPriceEuro
        {
            get { return DbConverter.ToStringNull(this["ConvertedPriceEuro"]); }
            set { this["ConvertedPriceEuro"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> ADDPAK
        {
            get { return DbConverter.ToStringNull(this["ADDPAK"]); }
            set { this["ADDPAK"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> S607ExternalDrainage
        {
            get { return DbConverter.ToStringNull(this["S607ExternalDrainage"]); }
            set { this["S607ExternalDrainage"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> FamilyGroup
        {
            get { return DbConverter.ToStringNull(this["FamilyGroup"]); }
            set { this["FamilyGroup"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> ReplacedByItem
        {
            get { return DbConverter.ToStringNull(this["ReplacedByItem"]); }
            set { this["ReplacedByItem"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> LongLocalDescriptionCS
        {
            get { return DbConverter.ToStringNull(this["LongLocalDescriptionCS"]); }
            set { this["LongLocalDescriptionCS"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> LongLocalDescriptionDA
        {
            get { return DbConverter.ToStringNull(this["LongLocalDescriptionDA"]); }
            set { this["LongLocalDescriptionDA"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> LongLocalDescriptionDE
        {
            get { return DbConverter.ToStringNull(this["LongLocalDescriptionDE"]); }
            set { this["LongLocalDescriptionDE"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> LongLocalDescriptionEN
        {
            get { return DbConverter.ToStringNull(this["LongLocalDescriptionEN"]); }
            set { this["LongLocalDescriptionEN"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> LongLocalDescriptionES
        {
            get { return DbConverter.ToStringNull(this["LongLocalDescriptionES"]); }
            set { this["LongLocalDescriptionES"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> LongLocalDescriptionFI
        {
            get { return DbConverter.ToStringNull(this["LongLocalDescriptionFI"]); }
            set { this["LongLocalDescriptionFI"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> LongLocalDescriptionFR
        {
            get { return DbConverter.ToStringNull(this["LongLocalDescriptionFR"]); }
            set { this["LongLocalDescriptionFR"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> LongLocalDescriptionHU
        {
            get { return DbConverter.ToStringNull(this["LongLocalDescriptionHU"]); }
            set { this["LongLocalDescriptionHU"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> LongLocalDescriptionIT
        {
            get { return DbConverter.ToStringNull(this["LongLocalDescriptionIT"]); }
            set { this["LongLocalDescriptionIT"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> LongLocalDescriptionNL
        {
            get { return DbConverter.ToStringNull(this["LongLocalDescriptionNL"]); }
            set { this["LongLocalDescriptionNL"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> LongLocalDescriptionNO
        {
            get { return DbConverter.ToStringNull(this["LongLocalDescriptionNO"]); }
            set { this["LongLocalDescriptionNO"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> LongLocalDescriptionPT
        {
            get { return DbConverter.ToStringNull(this["LongLocalDescriptionPT"]); }
            set { this["LongLocalDescriptionPT"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> LongLocalDescriptionSV
        {
            get { return DbConverter.ToStringNull(this["LongLocalDescriptionSV"]); }
            set { this["LongLocalDescriptionSV"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> TemporarilyRemoved
        {
            get { return DbConverter.ToStringNull(this["TemporarilyRemoved"]); }
            set { this["TemporarilyRemoved"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> Sterility
        {
            get { return DbConverter.ToStringNull(this["Sterility"]); }
            set { this["Sterility"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> NaturalRubberLATEX
        {
            get { return DbConverter.ToStringNull(this["NaturalRubberLATEX"]); }
            set { this["NaturalRubberLATEX"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> PVC
        {
            get { return DbConverter.ToStringNull(this["PVC"]); }
            set { this["PVC"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> Phthalates
        {
            get { return DbConverter.ToStringNull(this["Phthalates"]); }
            set { this["Phthalates"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> Pyrogens
        {
            get { return DbConverter.ToStringNull(this["Pyrogens"]); }
            set { this["Pyrogens"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> SalesRestriction
        {
            get { return DbConverter.ToStringNull(this["SalesRestriction"]); }
            set { this["SalesRestriction"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> ComponentClassificationMDD
        {
            get { return DbConverter.ToStringNull(this["ComponentClassificationMDD"]); }
            set { this["ComponentClassificationMDD"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> MDDClassificationRule
        {
            get { return DbConverter.ToStringNull(this["MDDClassificationRule"]); }
            set { this["MDDClassificationRule"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> IntendedUse
        {
            get { return DbConverter.ToStringNull(this["IntendedUse"]); }
            set { this["IntendedUse"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> NonInvasiveliquids
        {
            get { return DbConverter.ToStringNull(this["NonInvasiveliquids"]); }
            set { this["NonInvasiveliquids"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> SterilisationCycle
        {
            get { return DbConverter.ToStringNull(this["SterilisationCycle"]); }
            set { this["SterilisationCycle"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> FamilyGroup1
        {
            get { return DbConverter.ToStringNull(this["FamilyGroup1"]); }
            set { this["FamilyGroup1"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> PhaseOutDate
        {
            get { return DbConverter.ToStringNull(this["PhaseOutDate"]); }
            set { this["PhaseOutDate"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> ReasonForReplacement
        {
            get { return DbConverter.ToStringNull(this["ReasonForReplacement"]); }
            set { this["ReasonForReplacement"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> VAT
        {
            get { return DbConverter.ToStringNull(this["VAT"]); }
            set { this["VAT"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> CountryOfOriginOfTheMaterial
        {
            get { return DbConverter.ToStringNull(this["CountryOfOriginOfTheMaterial"]); }
            set { this["CountryOfOriginOfTheMaterial"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> ComponentDescriptionForLabelCS
        {
            get { return DbConverter.ToStringNull(this["ComponentDescriptionForLabelCS"]); }
            set { this["ComponentDescriptionForLabelCS"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> ComponentDescriptionForLabelDA
        {
            get { return DbConverter.ToStringNull(this["ComponentDescriptionForLabelDA"]); }
            set { this["ComponentDescriptionForLabelDA"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> ComponentDescriptionForLabelDE
        {
            get { return DbConverter.ToStringNull(this["ComponentDescriptionForLabelDE"]); }
            set { this["ComponentDescriptionForLabelDE"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> ComponentDescriptionForLabelEN
        {
            get { return DbConverter.ToStringNull(this["ComponentDescriptionForLabelEN"]); }
            set { this["ComponentDescriptionForLabelEN"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> ComponentDescriptionForLabelES
        {
            get { return DbConverter.ToStringNull(this["ComponentDescriptionForLabelES"]); }
            set { this["ComponentDescriptionForLabelES"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> ComponentDescriptionForLabelFI
        {
            get { return DbConverter.ToStringNull(this["ComponentDescriptionForLabelFI"]); }
            set { this["ComponentDescriptionForLabelFI"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> ComponentDescriptionForLabelFR
        {
            get { return DbConverter.ToStringNull(this["ComponentDescriptionForLabelFR"]); }
            set { this["ComponentDescriptionForLabelFR"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> ComponentDescriptionForLabelHU
        {
            get { return DbConverter.ToStringNull(this["ComponentDescriptionForLabelHU"]); }
            set { this["ComponentDescriptionForLabelHU"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> ComponentDescriptionForLabelIT
        {
            get { return DbConverter.ToStringNull(this["ComponentDescriptionForLabelIT"]); }
            set { this["ComponentDescriptionForLabelIT"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> ComponentDescriptionForLabelNL
        {
            get { return DbConverter.ToStringNull(this["ComponentDescriptionForLabelNL"]); }
            set { this["ComponentDescriptionForLabelNL"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> ComponentDescriptionForLabelNO
        {
            get { return DbConverter.ToStringNull(this["ComponentDescriptionForLabelNO"]); }
            set { this["ComponentDescriptionForLabelNO"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> ComponentDescriptionForLabelPT
        {
            get { return DbConverter.ToStringNull(this["ComponentDescriptionForLabelPT"]); }
            set { this["ComponentDescriptionForLabelPT"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> ComponentDescriptionForLabelSV
        {
            get { return DbConverter.ToStringNull(this["ComponentDescriptionForLabelSV"]); }
            set { this["ComponentDescriptionForLabelSV"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> QADate
        {
            get { return DbConverter.ToStringNull(this["QADate"]); }
            set { this["QADate"] = DbConverter.FromStringNull(value); }
        }

        protected override DbSchema GetSchema()
        {
            if (schema == null)
            {
                schema = new DbSchema("TMasterListTmp");
                schema.Add("KarvinaCode", typeof(string), "KarvinaCode", true);
                schema.Add("Category", typeof(string), "Category", true);
                schema.Add("pdmStatus", typeof(string), "pdmStatus", true);
                schema.Add("VendorName", typeof(string), "VendorName", true);
                schema.Add("VendorMatNo", typeof(string), "VendorMatNo", true);
                schema.Add("VendorCode", typeof(string), "VendorCode", true);
                schema.Add("Description", typeof(string), "Description", true);
                schema.Add("ConvertedPriceEuro", typeof(string), "ConvertedPriceEuro", true);
                schema.Add("ADDPAK", typeof(string), "ADDPAK", true);
                schema.Add("S607ExternalDrainage", typeof(string), "S607ExternalDrainage", true);
                schema.Add("FamilyGroup", typeof(string), "FamilyGroup", true);
                schema.Add("ReplacedByItem", typeof(string), "ReplacedByItem", true);
                schema.Add("LongLocalDescriptionCS", typeof(string), "LongLocalDescriptionCS", true);
                schema.Add("LongLocalDescriptionDA", typeof(string), "LongLocalDescriptionDA", true);
                schema.Add("LongLocalDescriptionDE", typeof(string), "LongLocalDescriptionDE", true);
                schema.Add("LongLocalDescriptionEN", typeof(string), "LongLocalDescriptionEN", true);
                schema.Add("LongLocalDescriptionES", typeof(string), "LongLocalDescriptionES", true);
                schema.Add("LongLocalDescriptionFI", typeof(string), "LongLocalDescriptionFI", true);
                schema.Add("LongLocalDescriptionFR", typeof(string), "LongLocalDescriptionFR", true);
                schema.Add("LongLocalDescriptionHU", typeof(string), "LongLocalDescriptionHU", true);
                schema.Add("LongLocalDescriptionIT", typeof(string), "LongLocalDescriptionIT", true);
                schema.Add("LongLocalDescriptionNL", typeof(string), "LongLocalDescriptionNL", true);
                schema.Add("LongLocalDescriptionNO", typeof(string), "LongLocalDescriptionNO", true);
                schema.Add("LongLocalDescriptionPT", typeof(string), "LongLocalDescriptionPT", true);
                schema.Add("LongLocalDescriptionSV", typeof(string), "LongLocalDescriptionSV", true);
                schema.Add("TemporarilyRemoved", typeof(string), "TemporarilyRemoved", true);
                schema.Add("Sterility", typeof(string), "Sterility", true);
                schema.Add("NaturalRubberLATEX", typeof(string), "NaturalRubberLATEX", true);
                schema.Add("PVC", typeof(string), "PVC", true);
                schema.Add("Phthalates", typeof(string), "Phthalates", true);
                schema.Add("Pyrogens", typeof(string), "Pyrogens", true);
                schema.Add("SalesRestriction", typeof(string), "SalesRestriction", true);
                schema.Add("ComponentClassificationMDD", typeof(string), "ComponentClassificationMDD", true);
                schema.Add("MDDClassificationRule", typeof(string), "MDDClassificationRule", true);
                schema.Add("IntendedUse", typeof(string), "IntendedUse", true);
                schema.Add("NonInvasiveliquids", typeof(string), "NonInvasiveliquids", true);
                schema.Add("SterilisationCycle", typeof(string), "SterilisationCycle", true);
                schema.Add("FamilyGroup1", typeof(string), "FamilyGroup1", true);
                schema.Add("PhaseOutDate", typeof(string), "PhaseOutDate", true);
                schema.Add("ReasonForReplacement", typeof(string), "ReasonForReplacement", true);
                schema.Add("VAT", typeof(string), "VAT", true);
                schema.Add("CountryOfOriginOfTheMaterial", typeof(string), "CountryOfOriginOfTheMaterial", true);
                schema.Add("ComponentDescriptionForLabelCS", typeof(string), "ComponentDescriptionForLabelCS", true);
                schema.Add("ComponentDescriptionForLabelDA", typeof(string), "ComponentDescriptionForLabelDA", true);
                schema.Add("ComponentDescriptionForLabelDE", typeof(string), "ComponentDescriptionForLabelDE", true);
                schema.Add("ComponentDescriptionForLabelEN", typeof(string), "ComponentDescriptionForLabelEN", true);
                schema.Add("ComponentDescriptionForLabelES", typeof(string), "ComponentDescriptionForLabelES", true);
                schema.Add("ComponentDescriptionForLabelFI", typeof(string), "ComponentDescriptionForLabelFI", true);
                schema.Add("ComponentDescriptionForLabelFR", typeof(string), "ComponentDescriptionForLabelFR", true);
                schema.Add("ComponentDescriptionForLabelHU", typeof(string), "ComponentDescriptionForLabelHU", true);
                schema.Add("ComponentDescriptionForLabelIT", typeof(string), "ComponentDescriptionForLabelIT", true);
                schema.Add("ComponentDescriptionForLabelNL", typeof(string), "ComponentDescriptionForLabelNL", true);
                schema.Add("ComponentDescriptionForLabelNO", typeof(string), "ComponentDescriptionForLabelNO", true);
                schema.Add("ComponentDescriptionForLabelPT", typeof(string), "ComponentDescriptionForLabelPT", true);
                schema.Add("ComponentDescriptionForLabelSV", typeof(string), "ComponentDescriptionForLabelSV", true);
                schema.Add("QADate", typeof(string), "QADate", true);
            }

            return schema;
        }

        public override void LoadDefaultValues()
        {
            SqlCommand command = Session.CreateCommand();

            this["KarvinaCode"] = DBNull.Value;

            this["Category"] = DBNull.Value;

            this["pdmStatus"] = DBNull.Value;

            this["VendorName"] = DBNull.Value;

            this["VendorMatNo"] = DBNull.Value;

            this["VendorCode"] = DBNull.Value;

            this["Description"] = DBNull.Value;

            this["ConvertedPriceEuro"] = DBNull.Value;

            this["ADDPAK"] = DBNull.Value;

            this["S607ExternalDrainage"] = DBNull.Value;

            this["FamilyGroup"] = DBNull.Value;

            this["ReplacedByItem"] = DBNull.Value;

            this["LongLocalDescriptionCS"] = DBNull.Value;

            this["LongLocalDescriptionDA"] = DBNull.Value;

            this["LongLocalDescriptionDE"] = DBNull.Value;

            this["LongLocalDescriptionEN"] = DBNull.Value;

            this["LongLocalDescriptionES"] = DBNull.Value;

            this["LongLocalDescriptionFI"] = DBNull.Value;

            this["LongLocalDescriptionFR"] = DBNull.Value;

            this["LongLocalDescriptionHU"] = DBNull.Value;

            this["LongLocalDescriptionIT"] = DBNull.Value;

            this["LongLocalDescriptionNL"] = DBNull.Value;

            this["LongLocalDescriptionNO"] = DBNull.Value;

            this["LongLocalDescriptionPT"] = DBNull.Value;

            this["LongLocalDescriptionSV"] = DBNull.Value;

            this["TemporarilyRemoved"] = DBNull.Value;

            this["Sterility"] = DBNull.Value;

            this["NaturalRubberLATEX"] = DBNull.Value;

            this["PVC"] = DBNull.Value;

            this["Phthalates"] = DBNull.Value;

            this["Pyrogens"] = DBNull.Value;

            this["SalesRestriction"] = DBNull.Value;

            this["ComponentClassificationMDD"] = DBNull.Value;

            this["MDDClassificationRule"] = DBNull.Value;

            this["IntendedUse"] = DBNull.Value;

            this["NonInvasiveliquids"] = DBNull.Value;

            this["SterilisationCycle"] = DBNull.Value;

            this["FamilyGroup1"] = DBNull.Value;

            this["PhaseOutDate"] = DBNull.Value;

            this["ReasonForReplacement"] = DBNull.Value;

            this["VAT"] = DBNull.Value;

            this["CountryOfOriginOfTheMaterial"] = DBNull.Value;

            this["ComponentDescriptionForLabelCS"] = DBNull.Value;

            this["ComponentDescriptionForLabelDA"] = DBNull.Value;

            this["ComponentDescriptionForLabelDE"] = DBNull.Value;

            this["ComponentDescriptionForLabelEN"] = DBNull.Value;

            this["ComponentDescriptionForLabelES"] = DBNull.Value;

            this["ComponentDescriptionForLabelFI"] = DBNull.Value;

            this["ComponentDescriptionForLabelFR"] = DBNull.Value;

            this["ComponentDescriptionForLabelHU"] = DBNull.Value;

            this["ComponentDescriptionForLabelIT"] = DBNull.Value;

            this["ComponentDescriptionForLabelNL"] = DBNull.Value;

            this["ComponentDescriptionForLabelNO"] = DBNull.Value;

            this["ComponentDescriptionForLabelPT"] = DBNull.Value;

            this["ComponentDescriptionForLabelSV"] = DBNull.Value;

            this["QADate"] = DBNull.Value;
        }

        public static TMasterListTmp Load()
        {
            TMasterListTmp result = new TMasterListTmp();
            result.LoadRecord();
            return result;
        }

        public static TMasterListTmp CachedLoad()
        {
            DbCache.TableKey key = new DbCache.TableKey("TMasterListTmp");
            DbCache.CacheRecord record;
            key.Set();
            if (DbCache.Contains(key))
            {
                record = DbCache.GetRecord(key);
                if (!record.IsValid())
                {
                    record.Value = Load();
                    record.LastUpdate = DateTime.Now;
                    record.Valid = true;
                }
            }
            else
            {
                record = new DbCache.CacheRecord();
                record.Value = Load();
                record.LastUpdate = DateTime.Now;
                record.Valid = true;
                DbCache.SetRecord(key, record);
            }
            return (TMasterListTmp)record.Value;
        }

        public static TMasterListTmp Create()
        {
            TMasterListTmp result = new TMasterListTmp();
            result.LoadDefaultValues();
            return result;
        }

        public static DbTable<TMasterListTmp> LoadAll()
        {
            DbTable<TMasterListTmp> table = new DbTable<TMasterListTmp>();
            TMasterListTmp prototype = new TMasterListTmp();
            prototype.LoadTable(table);
            return table;
        }

        public static DbTable<TMasterListTmp> LoadBy(string whereCondition, params object[] parameterValues)
        {
            DbTable<TMasterListTmp> table = new DbTable<TMasterListTmp>();
            TMasterListTmp prototype = new TMasterListTmp();
            prototype.LoadTable(table, whereCondition, parameterValues);
            return table;
        }
    }

    public class TKategorieKomponentu: DbObject
    {
        private static DbSchema schema = null;

        public string KategorieKomponentu
        {
            get { return DbConverter.ToString(this["KategorieKomponentu"]); }
            set { this["KategorieKomponentu"] = DbConverter.FromString(value); }
        }

        protected override DbSchema GetSchema()
        {
            if (schema == null)
            {
                schema = new DbSchema("TKategorieKomponentu");
                schema.Add("KategorieKomponentu", typeof(string), "KategorieKomponentu", false, true, false);
            }

            return schema;
        }

        public override void LoadDefaultValues()
        {
            SqlCommand command = Session.CreateCommand();

            this["KategorieKomponentu"] = DbConverter.DefaultString();
        }

        public static TKategorieKomponentu Load(string kategorieKomponentu)
        {
            TKategorieKomponentu result = new TKategorieKomponentu();
            result.LoadRecord(kategorieKomponentu);
            return result;
        }

        public static TKategorieKomponentu CachedLoad(string kategorieKomponentu)
        {
            DbCache.TableKey key = new DbCache.TableKey("TKategorieKomponentu");
            DbCache.CacheRecord record;
            key.Set(kategorieKomponentu);
            if (DbCache.Contains(key))
            {
                record = DbCache.GetRecord(key);
                if (!record.IsValid())
                {
                    record.Value = Load(kategorieKomponentu);
                    record.LastUpdate = DateTime.Now;
                    record.Valid = true;
                }
            }
            else
            {
                record = new DbCache.CacheRecord();
                record.Value = Load(kategorieKomponentu);
                record.LastUpdate = DateTime.Now;
                record.Valid = true;
                DbCache.SetRecord(key, record);
            }
            return (TKategorieKomponentu)record.Value;
        }

        public static TKategorieKomponentu Create()
        {
            TKategorieKomponentu result = new TKategorieKomponentu();
            result.LoadDefaultValues();
            return result;
        }

        public static DbTable<TKategorieKomponentu> LoadAll()
        {
            DbTable<TKategorieKomponentu> table = new DbTable<TKategorieKomponentu>();
            TKategorieKomponentu prototype = new TKategorieKomponentu();
            prototype.LoadTable(table);
            return table;
        }

        public static DbTable<TKategorieKomponentu> LoadBy(string whereCondition, params object[] parameterValues)
        {
            DbTable<TKategorieKomponentu> table = new DbTable<TKategorieKomponentu>();
            TKategorieKomponentu prototype = new TKategorieKomponentu();
            prototype.LoadTable(table, whereCondition, parameterValues);
            return table;
        }
    }

    public class TImageType: DbObject
    {
        private static DbSchema schema = null;

        public int ImageID
        {
            get { return DbConverter.ToInt(this["ImageID"]); }
            set { this["ImageID"] = DbConverter.FromInt(value); }
        }

        public DbNullable<string> ImageName
        {
            get { return DbConverter.ToStringNull(this["ImageName"]); }
            set { this["ImageName"] = DbConverter.FromStringNull(value); }
        }

        protected override DbSchema GetSchema()
        {
            if (schema == null)
            {
                schema = new DbSchema("TImageType");
                schema.Add("ImageID", typeof(int), "ImageID", false, true, true);
                schema.Add("ImageName", typeof(string), "ImageName", true);
            }

            return schema;
        }

        public override void LoadDefaultValues()
        {
            SqlCommand command = Session.CreateCommand();

            this["ImageID"] = DbConverter.DefaultInt();

            this["ImageName"] = DBNull.Value;
        }

        public static TImageType Load(int imageID)
        {
            TImageType result = new TImageType();
            result.LoadRecord(imageID);
            return result;
        }

        public static TImageType CachedLoad(int imageID)
        {
            DbCache.TableKey key = new DbCache.TableKey("TImageType");
            DbCache.CacheRecord record;
            key.Set(imageID);
            if (DbCache.Contains(key))
            {
                record = DbCache.GetRecord(key);
                if (!record.IsValid())
                {
                    record.Value = Load(imageID);
                    record.LastUpdate = DateTime.Now;
                    record.Valid = true;
                }
            }
            else
            {
                record = new DbCache.CacheRecord();
                record.Value = Load(imageID);
                record.LastUpdate = DateTime.Now;
                record.Valid = true;
                DbCache.SetRecord(key, record);
            }
            return (TImageType)record.Value;
        }

        public static TImageType Create()
        {
            TImageType result = new TImageType();
            result.LoadDefaultValues();
            return result;
        }

        public static DbTable<TImageType> LoadAll()
        {
            DbTable<TImageType> table = new DbTable<TImageType>();
            TImageType prototype = new TImageType();
            prototype.LoadTable(table);
            return table;
        }

        public static DbTable<TImageType> LoadBy(string whereCondition, params object[] parameterValues)
        {
            DbTable<TImageType> table = new DbTable<TImageType>();
            TImageType prototype = new TImageType();
            prototype.LoadTable(table, whereCondition, parameterValues);
            return table;
        }
    }

    public class TZeme: DbObject
    {
        private static DbSchema schema = null;

        public int IDZeme
        {
            get { return DbConverter.ToInt(this["IDZeme"]); }
            set { this["IDZeme"] = DbConverter.FromInt(value); }
        }

        public DbNullable<string> Zeme
        {
            get { return DbConverter.ToStringNull(this["Zeme"]); }
            set { this["Zeme"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> Text
        {
            get { return DbConverter.ToStringNull(this["Text"]); }
            set { this["Text"] = DbConverter.FromStringNull(value); }
        }

        protected override DbSchema GetSchema()
        {
            if (schema == null)
            {
                schema = new DbSchema("TZeme");
                schema.Add("IDZeme", typeof(int), "IDZeme", false, true, true);
                schema.Add("Zeme", typeof(string), "Zeme", true);
                schema.Add("Text", typeof(string), "Text", true);
            }

            return schema;
        }

        public override void LoadDefaultValues()
        {
            SqlCommand command = Session.CreateCommand();

            this["IDZeme"] = DbConverter.DefaultInt();

            this["Zeme"] = DBNull.Value;

            this["Text"] = DBNull.Value;
        }

        public static TZeme Load(int iDZeme)
        {
            TZeme result = new TZeme();
            result.LoadRecord(iDZeme);
            return result;
        }

        public static TZeme CachedLoad(int iDZeme)
        {
            DbCache.TableKey key = new DbCache.TableKey("TZeme");
            DbCache.CacheRecord record;
            key.Set(iDZeme);
            if (DbCache.Contains(key))
            {
                record = DbCache.GetRecord(key);
                if (!record.IsValid())
                {
                    record.Value = Load(iDZeme);
                    record.LastUpdate = DateTime.Now;
                    record.Valid = true;
                }
            }
            else
            {
                record = new DbCache.CacheRecord();
                record.Value = Load(iDZeme);
                record.LastUpdate = DateTime.Now;
                record.Valid = true;
                DbCache.SetRecord(key, record);
            }
            return (TZeme)record.Value;
        }

        public static TZeme Create()
        {
            TZeme result = new TZeme();
            result.LoadDefaultValues();
            return result;
        }

        public static DbTable<TZeme> LoadAll()
        {
            DbTable<TZeme> table = new DbTable<TZeme>();
            TZeme prototype = new TZeme();
            prototype.LoadTable(table);
            return table;
        }

        public static DbTable<TZeme> LoadBy(string whereCondition, params object[] parameterValues)
        {
            DbTable<TZeme> table = new DbTable<TZeme>();
            TZeme prototype = new TZeme();
            prototype.LoadTable(table, whereCondition, parameterValues);
            return table;
        }
    }

    public class TBatch: DbObject
    {
        private static DbSchema schema = null;

        public int ID
        {
            get { return DbConverter.ToInt(this["ID"]); }
            set { this["ID"] = DbConverter.FromInt(value); }
        }

        public DbNullable<string> OrderNumber
        {
            get { return DbConverter.ToStringNull(this["OrderNumber"]); }
            set { this["OrderNumber"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> MaterialNumber
        {
            get { return DbConverter.ToStringNull(this["MaterialNumber"]); }
            set { this["MaterialNumber"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<int> OrderQuantity
        {
            get { return DbConverter.ToIntNull(this["OrderQuantity"]); }
            set { this["OrderQuantity"] = DbConverter.FromIntNull(value); }
        }

        public DbNullable<string> BatchNumber
        {
            get { return DbConverter.ToStringNull(this["BatchNumber"]); }
            set { this["BatchNumber"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> ProductLine
        {
            get { return DbConverter.ToStringNull(this["ProductLine"]); }
            set { this["ProductLine"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> Shift
        {
            get { return DbConverter.ToStringNull(this["Shift"]); }
            set { this["Shift"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<decimal> Weight
        {
            get { return DbConverter.ToDecimalNull(this["Weight"]); }
            set { this["Weight"] = DbConverter.FromDecimalNull(value); }
        }

        public DbNullable<string> Box
        {
            get { return DbConverter.ToStringNull(this["Box"]); }
            set { this["Box"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<DateTime> DateWrite
        {
            get { return DbConverter.ToDateTimeNull(this["DateWrite"]); }
            set { this["DateWrite"] = DbConverter.FromDateTimeNull(value); }
        }

        protected override DbSchema GetSchema()
        {
            if (schema == null)
            {
                schema = new DbSchema("TBatch");
                schema.Add("ID", typeof(int), "ID", false, true, true);
                schema.Add("OrderNumber", typeof(string), "OrderNumber", true);
                schema.Add("MaterialNumber", typeof(string), "MaterialNumber", true);
                schema.Add("OrderQuantity", typeof(int), "OrderQuantity", true);
                schema.Add("BatchNumber", typeof(string), "BatchNumber", true);
                schema.Add("ProductLine", typeof(string), "ProductLine", true);
                schema.Add("Shift", typeof(string), "Shift", true);
                schema.Add("Weight", typeof(decimal), "Weight", true);
                schema.Add("Box", typeof(string), "Box", true);
                schema.Add("DateWrite", typeof(DateTime), "DateWrite", true);
            }

            return schema;
        }

        public override void LoadDefaultValues()
        {
            SqlCommand command = Session.CreateCommand();

            this["ID"] = DbConverter.DefaultInt();

            this["OrderNumber"] = DBNull.Value;

            this["MaterialNumber"] = DBNull.Value;

            this["OrderQuantity"] = DBNull.Value;

            this["BatchNumber"] = DBNull.Value;

            this["ProductLine"] = DBNull.Value;

            this["Shift"] = DBNull.Value;

            this["Weight"] = DBNull.Value;

            this["Box"] = DBNull.Value;

            command.CommandText = "SELECT (getdate())";
            this["DateWrite"] = command.ExecuteScalar();
        }

        public static TBatch Load(int iD)
        {
            TBatch result = new TBatch();
            result.LoadRecord(iD);
            return result;
        }

        public static TBatch CachedLoad(int iD)
        {
            DbCache.TableKey key = new DbCache.TableKey("TBatch");
            DbCache.CacheRecord record;
            key.Set(iD);
            if (DbCache.Contains(key))
            {
                record = DbCache.GetRecord(key);
                if (!record.IsValid())
                {
                    record.Value = Load(iD);
                    record.LastUpdate = DateTime.Now;
                    record.Valid = true;
                }
            }
            else
            {
                record = new DbCache.CacheRecord();
                record.Value = Load(iD);
                record.LastUpdate = DateTime.Now;
                record.Valid = true;
                DbCache.SetRecord(key, record);
            }
            return (TBatch)record.Value;
        }

        public static TBatch Create()
        {
            TBatch result = new TBatch();
            result.LoadDefaultValues();
            return result;
        }

        public static DbTable<TBatch> LoadAll()
        {
            DbTable<TBatch> table = new DbTable<TBatch>();
            TBatch prototype = new TBatch();
            prototype.LoadTable(table);
            return table;
        }

        public static DbTable<TBatch> LoadBy(string whereCondition, params object[] parameterValues)
        {
            DbTable<TBatch> table = new DbTable<TBatch>();
            TBatch prototype = new TBatch();
            prototype.LoadTable(table, whereCondition, parameterValues);
            return table;
        }
    }

    public class dtproperties: DbObject
    {
        private static DbSchema schema = null;

        public int id
        {
            get { return DbConverter.ToInt(this["id"]); }
            set { this["id"] = DbConverter.FromInt(value); }
        }

        public DbNullable<int> objectid
        {
            get { return DbConverter.ToIntNull(this["objectid"]); }
            set { this["objectid"] = DbConverter.FromIntNull(value); }
        }

        public string property
        {
            get { return DbConverter.ToString(this["property"]); }
            set { this["property"] = DbConverter.FromString(value); }
        }

        public DbNullable<string> value
        {
            get { return DbConverter.ToStringNull(this["value"]); }
            set { this["value"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> uvalue
        {
            get { return DbConverter.ToStringNull(this["uvalue"]); }
            set { this["uvalue"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<byte[]> lvalue
        {
            get { return DbConverter.ToArrayNull(this["lvalue"]); }
            set { this["lvalue"] = DbConverter.FromArrayNull(value); }
        }

        public int version
        {
            get { return DbConverter.ToInt(this["version"]); }
            set { this["version"] = DbConverter.FromInt(value); }
        }

        protected override DbSchema GetSchema()
        {
            if (schema == null)
            {
                schema = new DbSchema("dtproperties");
                schema.Add("id", typeof(int), "id", false, true, true);
                schema.Add("objectid", typeof(int), "objectid", true);
                schema.Add("property", typeof(string), "property", false, true, false);
                schema.Add("value", typeof(string), "value", true);
                schema.Add("uvalue", typeof(string), "uvalue", true);
                schema.Add("lvalue", typeof(byte[]), "lvalue", true);
                schema.Add("version", typeof(int), "version", false);
            }

            return schema;
        }

        public override void LoadDefaultValues()
        {
            SqlCommand command = Session.CreateCommand();

            this["id"] = DbConverter.DefaultInt();

            this["objectid"] = DBNull.Value;

            this["property"] = DbConverter.DefaultString();

            this["value"] = DBNull.Value;

            this["uvalue"] = DBNull.Value;

            this["lvalue"] = DBNull.Value;

            command.CommandText = "SELECT (0)";
            this["version"] = command.ExecuteScalar();
        }

        public static dtproperties Load(int id, string property)
        {
            dtproperties result = new dtproperties();
            result.LoadRecord(id, property);
            return result;
        }

        public static dtproperties CachedLoad(int id, string property)
        {
            DbCache.TableKey key = new DbCache.TableKey("dtproperties");
            DbCache.CacheRecord record;
            key.Set(id, property);
            if (DbCache.Contains(key))
            {
                record = DbCache.GetRecord(key);
                if (!record.IsValid())
                {
                    record.Value = Load(id, property);
                    record.LastUpdate = DateTime.Now;
                    record.Valid = true;
                }
            }
            else
            {
                record = new DbCache.CacheRecord();
                record.Value = Load(id, property);
                record.LastUpdate = DateTime.Now;
                record.Valid = true;
                DbCache.SetRecord(key, record);
            }
            return (dtproperties)record.Value;
        }

        public static dtproperties Create()
        {
            dtproperties result = new dtproperties();
            result.LoadDefaultValues();
            return result;
        }

        public static DbTable<dtproperties> LoadAll()
        {
            DbTable<dtproperties> table = new DbTable<dtproperties>();
            dtproperties prototype = new dtproperties();
            prototype.LoadTable(table);
            return table;
        }

        public static DbTable<dtproperties> LoadBy(string whereCondition, params object[] parameterValues)
        {
            DbTable<dtproperties> table = new DbTable<dtproperties>();
            dtproperties prototype = new dtproperties();
            prototype.LoadTable(table, whereCondition, parameterValues);
            return table;
        }
    }

    public class TTypeComplaint: DbObject
    {
        private static DbSchema schema = null;

        public int IDTypeComplaint
        {
            get { return DbConverter.ToInt(this["IDTypeComplaint"]); }
            set { this["IDTypeComplaint"] = DbConverter.FromInt(value); }
        }

        public string TypeComplaint
        {
            get { return DbConverter.ToString(this["TypeComplaint"]); }
            set { this["TypeComplaint"] = DbConverter.FromString(value); }
        }

        protected override DbSchema GetSchema()
        {
            if (schema == null)
            {
                schema = new DbSchema("TTypeComplaint");
                schema.Add("IDTypeComplaint", typeof(int), "IDTypeComplaint", false, true, true);
                schema.Add("TypeComplaint", typeof(string), "TypeComplaint", false);
            }

            return schema;
        }

        public override void LoadDefaultValues()
        {
            SqlCommand command = Session.CreateCommand();

            this["IDTypeComplaint"] = DbConverter.DefaultInt();

            this["TypeComplaint"] = DbConverter.DefaultString();
        }

        public static TTypeComplaint Load(int iDTypeComplaint)
        {
            TTypeComplaint result = new TTypeComplaint();
            result.LoadRecord(iDTypeComplaint);
            return result;
        }

        public static TTypeComplaint CachedLoad(int iDTypeComplaint)
        {
            DbCache.TableKey key = new DbCache.TableKey("TTypeComplaint");
            DbCache.CacheRecord record;
            key.Set(iDTypeComplaint);
            if (DbCache.Contains(key))
            {
                record = DbCache.GetRecord(key);
                if (!record.IsValid())
                {
                    record.Value = Load(iDTypeComplaint);
                    record.LastUpdate = DateTime.Now;
                    record.Valid = true;
                }
            }
            else
            {
                record = new DbCache.CacheRecord();
                record.Value = Load(iDTypeComplaint);
                record.LastUpdate = DateTime.Now;
                record.Valid = true;
                DbCache.SetRecord(key, record);
            }
            return (TTypeComplaint)record.Value;
        }

        public static TTypeComplaint Create()
        {
            TTypeComplaint result = new TTypeComplaint();
            result.LoadDefaultValues();
            return result;
        }

        public static DbTable<TTypeComplaint> LoadAll()
        {
            DbTable<TTypeComplaint> table = new DbTable<TTypeComplaint>();
            TTypeComplaint prototype = new TTypeComplaint();
            prototype.LoadTable(table);
            return table;
        }

        public static DbTable<TTypeComplaint> LoadBy(string whereCondition, params object[] parameterValues)
        {
            DbTable<TTypeComplaint> table = new DbTable<TTypeComplaint>();
            TTypeComplaint prototype = new TTypeComplaint();
            prototype.LoadTable(table, whereCondition, parameterValues);
            return table;
        }
    }

    public class TCountry: DbObject
    {
        private static DbSchema schema = null;

        public string CountryCode
        {
            get { return DbConverter.ToString(this["CountryCode"]); }
            set { this["CountryCode"] = DbConverter.FromString(value); }
        }

        public DbNullable<string> Country
        {
            get { return DbConverter.ToStringNull(this["Country"]); }
            set { this["Country"] = DbConverter.FromStringNull(value); }
        }

        protected override DbSchema GetSchema()
        {
            if (schema == null)
            {
                schema = new DbSchema("TCountry");
                schema.Add("CountryCode", typeof(string), "CountryCode", false, true, false);
                schema.Add("Country", typeof(string), "Country", true);
            }

            return schema;
        }

        public override void LoadDefaultValues()
        {
            SqlCommand command = Session.CreateCommand();

            this["CountryCode"] = DbConverter.DefaultString();

            this["Country"] = DBNull.Value;
        }

        public static TCountry Load(string countryCode)
        {
            TCountry result = new TCountry();
            result.LoadRecord(countryCode);
            return result;
        }

        public static TCountry CachedLoad(string countryCode)
        {
            DbCache.TableKey key = new DbCache.TableKey("TCountry");
            DbCache.CacheRecord record;
            key.Set(countryCode);
            if (DbCache.Contains(key))
            {
                record = DbCache.GetRecord(key);
                if (!record.IsValid())
                {
                    record.Value = Load(countryCode);
                    record.LastUpdate = DateTime.Now;
                    record.Valid = true;
                }
            }
            else
            {
                record = new DbCache.CacheRecord();
                record.Value = Load(countryCode);
                record.LastUpdate = DateTime.Now;
                record.Valid = true;
                DbCache.SetRecord(key, record);
            }
            return (TCountry)record.Value;
        }

        public static TCountry Create()
        {
            TCountry result = new TCountry();
            result.LoadDefaultValues();
            return result;
        }

        public static DbTable<TCountry> LoadAll()
        {
            DbTable<TCountry> table = new DbTable<TCountry>();
            TCountry prototype = new TCountry();
            prototype.LoadTable(table);
            return table;
        }

        public static DbTable<TCountry> LoadBy(string whereCondition, params object[] parameterValues)
        {
            DbTable<TCountry> table = new DbTable<TCountry>();
            TCountry prototype = new TCountry();
            prototype.LoadTable(table, whereCondition, parameterValues);
            return table;
        }
    }

    public class TCorrection: DbObject
    {
        private static DbSchema schema = null;

        public int CorrectionID
        {
            get { return DbConverter.ToInt(this["CorrectionID"]); }
            set { this["CorrectionID"] = DbConverter.FromInt(value); }
        }

        public DbNullable<string> CorrectionName
        {
            get { return DbConverter.ToStringNull(this["CorrectionName"]); }
            set { this["CorrectionName"] = DbConverter.FromStringNull(value); }
        }

        protected override DbSchema GetSchema()
        {
            if (schema == null)
            {
                schema = new DbSchema("TCorrection");
                schema.Add("CorrectionID", typeof(int), "CorrectionID", false, true, true);
                schema.Add("CorrectionName", typeof(string), "CorrectionName", true);
            }

            return schema;
        }

        public override void LoadDefaultValues()
        {
            SqlCommand command = Session.CreateCommand();

            this["CorrectionID"] = DbConverter.DefaultInt();

            this["CorrectionName"] = DBNull.Value;
        }

        public static TCorrection Load(int correctionID)
        {
            TCorrection result = new TCorrection();
            result.LoadRecord(correctionID);
            return result;
        }

        public static TCorrection CachedLoad(int correctionID)
        {
            DbCache.TableKey key = new DbCache.TableKey("TCorrection");
            DbCache.CacheRecord record;
            key.Set(correctionID);
            if (DbCache.Contains(key))
            {
                record = DbCache.GetRecord(key);
                if (!record.IsValid())
                {
                    record.Value = Load(correctionID);
                    record.LastUpdate = DateTime.Now;
                    record.Valid = true;
                }
            }
            else
            {
                record = new DbCache.CacheRecord();
                record.Value = Load(correctionID);
                record.LastUpdate = DateTime.Now;
                record.Valid = true;
                DbCache.SetRecord(key, record);
            }
            return (TCorrection)record.Value;
        }

        public static TCorrection Create()
        {
            TCorrection result = new TCorrection();
            result.LoadDefaultValues();
            return result;
        }

        public static DbTable<TCorrection> LoadAll()
        {
            DbTable<TCorrection> table = new DbTable<TCorrection>();
            TCorrection prototype = new TCorrection();
            prototype.LoadTable(table);
            return table;
        }

        public static DbTable<TCorrection> LoadBy(string whereCondition, params object[] parameterValues)
        {
            DbTable<TCorrection> table = new DbTable<TCorrection>();
            TCorrection prototype = new TCorrection();
            prototype.LoadTable(table, whereCondition, parameterValues);
            return table;
        }
    }

    public class TTypeSamples: DbObject
    {
        private static DbSchema schema = null;

        public int IDTypeSamples
        {
            get { return DbConverter.ToInt(this["IDTypeSamples"]); }
            set { this["IDTypeSamples"] = DbConverter.FromInt(value); }
        }

        public string TypeSamples
        {
            get { return DbConverter.ToString(this["TypeSamples"]); }
            set { this["TypeSamples"] = DbConverter.FromString(value); }
        }

        protected override DbSchema GetSchema()
        {
            if (schema == null)
            {
                schema = new DbSchema("TTypeSamples");
                schema.Add("IDTypeSamples", typeof(int), "IDTypeSamples", false, true, true);
                schema.Add("TypeSamples", typeof(string), "TypeSamples", false);
            }

            return schema;
        }

        public override void LoadDefaultValues()
        {
            SqlCommand command = Session.CreateCommand();

            this["IDTypeSamples"] = DbConverter.DefaultInt();

            this["TypeSamples"] = DbConverter.DefaultString();
        }

        public static TTypeSamples Load(int iDTypeSamples)
        {
            TTypeSamples result = new TTypeSamples();
            result.LoadRecord(iDTypeSamples);
            return result;
        }

        public static TTypeSamples CachedLoad(int iDTypeSamples)
        {
            DbCache.TableKey key = new DbCache.TableKey("TTypeSamples");
            DbCache.CacheRecord record;
            key.Set(iDTypeSamples);
            if (DbCache.Contains(key))
            {
                record = DbCache.GetRecord(key);
                if (!record.IsValid())
                {
                    record.Value = Load(iDTypeSamples);
                    record.LastUpdate = DateTime.Now;
                    record.Valid = true;
                }
            }
            else
            {
                record = new DbCache.CacheRecord();
                record.Value = Load(iDTypeSamples);
                record.LastUpdate = DateTime.Now;
                record.Valid = true;
                DbCache.SetRecord(key, record);
            }
            return (TTypeSamples)record.Value;
        }

        public static TTypeSamples Create()
        {
            TTypeSamples result = new TTypeSamples();
            result.LoadDefaultValues();
            return result;
        }

        public static DbTable<TTypeSamples> LoadAll()
        {
            DbTable<TTypeSamples> table = new DbTable<TTypeSamples>();
            TTypeSamples prototype = new TTypeSamples();
            prototype.LoadTable(table);
            return table;
        }

        public static DbTable<TTypeSamples> LoadBy(string whereCondition, params object[] parameterValues)
        {
            DbTable<TTypeSamples> table = new DbTable<TTypeSamples>();
            TTypeSamples prototype = new TTypeSamples();
            prototype.LoadTable(table, whereCondition, parameterValues);
            return table;
        }
    }

    public class TImportSAP: DbObject
    {
        private static DbSchema schema = null;

        public DbNullable<string> Notification
        {
            get { return DbConverter.ToStringNull(this["Notification"]); }
            set { this["Notification"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> Country
        {
            get { return DbConverter.ToStringNull(this["Country"]); }
            set { this["Country"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> Customer
        {
            get { return DbConverter.ToStringNull(this["Customer"]); }
            set { this["Customer"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> CreatedBy
        {
            get { return DbConverter.ToStringNull(this["CreatedBy"]); }
            set { this["CreatedBy"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<DateTime> CreatedOn
        {
            get { return DbConverter.ToDateTimeNull(this["CreatedOn"]); }
            set { this["CreatedOn"] = DbConverter.FromDateTimeNull(value); }
        }

        public DbNullable<string> PlantForMat
        {
            get { return DbConverter.ToStringNull(this["PlantForMat"]); }
            set { this["PlantForMat"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> CodingCodeTXT
        {
            get { return DbConverter.ToStringNull(this["CodingCodeTXT"]); }
            set { this["CodingCodeTXT"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> Material
        {
            get { return DbConverter.ToStringNull(this["Material"]); }
            set { this["Material"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> Batch
        {
            get { return DbConverter.ToStringNull(this["Batch"]); }
            set { this["Batch"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> Description
        {
            get { return DbConverter.ToStringNull(this["Description"]); }
            set { this["Description"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<DateTime> RequiredEnd
        {
            get { return DbConverter.ToDateTimeNull(this["RequiredEnd"]); }
            set { this["RequiredEnd"] = DbConverter.FromDateTimeNull(value); }
        }

        public DbNullable<string> Status
        {
            get { return DbConverter.ToStringNull(this["Status"]); }
            set { this["Status"] = DbConverter.FromStringNull(value); }
        }

        protected override DbSchema GetSchema()
        {
            if (schema == null)
            {
                schema = new DbSchema("TImportSAP");
                schema.Add("Notification", typeof(string), "Notification", true);
                schema.Add("Country", typeof(string), "Country", true);
                schema.Add("Customer", typeof(string), "Customer", true);
                schema.Add("CreatedBy", typeof(string), "CreatedBy", true);
                schema.Add("CreatedOn", typeof(DateTime), "CreatedOn", true);
                schema.Add("PlantForMat", typeof(string), "PlantForMat", true);
                schema.Add("CodingCodeTXT", typeof(string), "CodingCodeTXT", true);
                schema.Add("Material", typeof(string), "Material", true);
                schema.Add("Batch", typeof(string), "Batch", true);
                schema.Add("Description", typeof(string), "Description", true);
                schema.Add("RequiredEnd", typeof(DateTime), "RequiredEnd", true);
                schema.Add("Status", typeof(string), "Status", true);
            }

            return schema;
        }

        public override void LoadDefaultValues()
        {
            SqlCommand command = Session.CreateCommand();

            this["Notification"] = DBNull.Value;

            this["Country"] = DBNull.Value;

            this["Customer"] = DBNull.Value;

            this["CreatedBy"] = DBNull.Value;

            this["CreatedOn"] = DBNull.Value;

            this["PlantForMat"] = DBNull.Value;

            this["CodingCodeTXT"] = DBNull.Value;

            this["Material"] = DBNull.Value;

            this["Batch"] = DBNull.Value;

            this["Description"] = DBNull.Value;

            this["RequiredEnd"] = DBNull.Value;

            this["Status"] = DBNull.Value;
        }

        public static TImportSAP Load()
        {
            TImportSAP result = new TImportSAP();
            result.LoadRecord();
            return result;
        }

        public static TImportSAP CachedLoad()
        {
            DbCache.TableKey key = new DbCache.TableKey("TImportSAP");
            DbCache.CacheRecord record;
            key.Set();
            if (DbCache.Contains(key))
            {
                record = DbCache.GetRecord(key);
                if (!record.IsValid())
                {
                    record.Value = Load();
                    record.LastUpdate = DateTime.Now;
                    record.Valid = true;
                }
            }
            else
            {
                record = new DbCache.CacheRecord();
                record.Value = Load();
                record.LastUpdate = DateTime.Now;
                record.Valid = true;
                DbCache.SetRecord(key, record);
            }
            return (TImportSAP)record.Value;
        }

        public static TImportSAP Create()
        {
            TImportSAP result = new TImportSAP();
            result.LoadDefaultValues();
            return result;
        }

        public static DbTable<TImportSAP> LoadAll()
        {
            DbTable<TImportSAP> table = new DbTable<TImportSAP>();
            TImportSAP prototype = new TImportSAP();
            prototype.LoadTable(table);
            return table;
        }

        public static DbTable<TImportSAP> LoadBy(string whereCondition, params object[] parameterValues)
        {
            DbTable<TImportSAP> table = new DbTable<TImportSAP>();
            TImportSAP prototype = new TImportSAP();
            prototype.LoadTable(table, whereCondition, parameterValues);
            return table;
        }
    }
}
