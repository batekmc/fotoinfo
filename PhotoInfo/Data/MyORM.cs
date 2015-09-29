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

    public class QFComponentsPhoto: DbObject
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

        public DbNullable<string> PVC
        {
            get { return DbConverter.ToStringNull(this["PVC"]); }
            set { this["PVC"] = DbConverter.FromStringNull(value); }
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

        // ADD
        public DbNullable<string> AvailabilityName
        {
            get { return DbConverter.ToStringNull(this["AvailabilityName"]); }
            set { this["AvailabilityName"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> NafotilKdoStr
        {
            get { return DbConverter.ToStringNull(this["NafotilKdoStr"]); }
            set { this["NafotilKdoStr"] = DbConverter.FromStringNull(value); }
        }

        public DbNullable<string> PDMStatusPhoto
        {
            get { return DbConverter.ToStringNull(this["PDMStatusPhoto"]); }
            set { this["PDMStatusPhoto"] = DbConverter.FromStringNull(value); }
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
                schema = new DbSchema("QFComponentsPhoto");
                schema.Add("ComponentID", typeof(int), "ComponentID", false, true, true);
                schema.Add("Code", typeof(string), "Code", false);
                schema.Add("Vendor", typeof(string), "Vendor", true);
                schema.Add("Description", typeof(string), "Description", true);
                //schema.Add("ProdApprovPDM", typeof(DateTime), "ProdApprovPDM", true);
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
                schema.Add("EOD", typeof(string), "EOD", true);
                schema.Add("SCRAP", typeof(int), "SCRAP", true);
                schema.Add("SCRAPdate", typeof(DateTime), "SCRAPdate", true);
                schema.Add("New", typeof(bool), "New", false);
                schema.Add("ReasonSubst", typeof(string), "ReasonSubst", true);
                schema.Add("VendorPhoto", typeof(string), "VendorPhoto", true);
                schema.Add("ZmenaDesignu", typeof(bool), "ZmenaDesignu", false);
                schema.Add("ZmenaDatum", typeof(DateTime), "ZmenaDatum", true);
                schema.Add("ZmenaPozn", typeof(string), "ZmenaPozn", true);
                schema.Add("Vaha", typeof(decimal), "Vaha", true);
                schema.Add("VahaPoznamka", typeof(string), "VahaPoznamka", true);
                schema.Add("TimeRevision", typeof(bool), "TimeRevision", false);
                schema.Add("PcsBIN2", typeof(int), "PcsBIN2", true);
                // added
                schema.Add("AvailabilityName", typeof(string), "AvailabilityName", true);
                schema.Add("NafotilKdoStr", typeof(string), "NafotilKdoStr", true);
                schema.Add("PDMStatusPhoto", typeof(string), "PDMStatusPhoto", true);
                schema.Add("KomponentKategorieName", typeof(string), "KomponentKategorieName", true);
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

            //this["ProdApprovPDM"] = DBNull.Value;

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

            this["EOD"] = DBNull.Value;

            this["SCRAP"] = DBNull.Value;

            this["SCRAPdate"] = DBNull.Value;

            command.CommandText = "SELECT (1)";
            this["New"] = command.ExecuteScalar();

            this["ReasonSubst"] = DBNull.Value;

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

            this["NafotilKdoStr"] = DBNull.Value;

            this["AvailabilityName"] = DBNull.Value;

            this["PDMStatusPhoto"] = DBNull.Value;

            this["KomponentKategorieName"] = DBNull.Value;
        }

        public static QFComponentsPhoto Load(int componentID)
        {
            QFComponentsPhoto result = new QFComponentsPhoto();
            result.LoadRecord(componentID);
            return result;
        }

        public static QFComponentsPhoto CachedLoad(int componentID)
        {
            DbCache.TableKey key = new DbCache.TableKey("QFComponentsPhoto");
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
            return (QFComponentsPhoto)record.Value;
        }

        public static QFComponentsPhoto Create()
        {
            QFComponentsPhoto result = new QFComponentsPhoto();
            result.LoadDefaultValues();
            return result;
        }

        public static DbTable<QFComponentsPhoto> LoadAll()
        {
            DbTable<QFComponentsPhoto> table = new DbTable<QFComponentsPhoto>();
            QFComponentsPhoto prototype = new QFComponentsPhoto();
            prototype.LoadTable(table);
            return table;
        }

        public static DbTable<QFComponentsPhoto> LoadByPDMStatusPhotoID(DbNullable<int> pDMStatusPhotoID)
        {
            DbTable<QFComponentsPhoto> table = new DbTable<QFComponentsPhoto>();
            QFComponentsPhoto prototype = new QFComponentsPhoto();
            prototype.LoadTable(table, "[PDMStatusPhotoID]={0}", DbConverter.FromIntNull(pDMStatusPhotoID));
            return table;
        }

        public static DbTable<QFComponentsPhoto> LoadByKategorieKomponentu(DbNullable<string> kategorieKomponentu)
        {
            DbTable<QFComponentsPhoto> table = new DbTable<QFComponentsPhoto>();
            QFComponentsPhoto prototype = new QFComponentsPhoto();
            prototype.LoadTable(table, "[KategorieKomponentu]={0}", DbConverter.FromStringNull(kategorieKomponentu));
            return table;
        }

        public static DbTable<QFComponentsPhoto> LoadByKomponentKategorieID(DbNullable<int> komponentKategorieID)
        {
            DbTable<QFComponentsPhoto> table = new DbTable<QFComponentsPhoto>();
            QFComponentsPhoto prototype = new QFComponentsPhoto();
            prototype.LoadTable(table, "[KomponentKategorieID]={0}", DbConverter.FromIntNull(komponentKategorieID));
            return table;
        }

        public static DbTable<QFComponentsPhoto> LoadByNafotilKdoID(DbNullable<int> nafotilKdoID)
        {
            DbTable<QFComponentsPhoto> table = new DbTable<QFComponentsPhoto>();
            QFComponentsPhoto prototype = new QFComponentsPhoto();
            prototype.LoadTable(table, "[NafotilKdoID]={0}", DbConverter.FromIntNull(nafotilKdoID));
            return table;
        }

        public static DbTable<QFComponentsPhoto> LoadByDostupnostID(DbNullable<int> dostupnostID)
        {
            DbTable<QFComponentsPhoto> table = new DbTable<QFComponentsPhoto>();
            QFComponentsPhoto prototype = new QFComponentsPhoto();
            prototype.LoadTable(table, "[DostupnostID]={0}", DbConverter.FromIntNull(dostupnostID));
            return table;
        }

        public static DbTable<QFComponentsPhoto> LoadBy(string whereCondition, params object[] parameterValues)
        {
            DbTable<QFComponentsPhoto> table = new DbTable<QFComponentsPhoto>();
            QFComponentsPhoto prototype = new QFComponentsPhoto();
            prototype.LoadTable(table, whereCondition, parameterValues);
            return table;
        }
    }

}
