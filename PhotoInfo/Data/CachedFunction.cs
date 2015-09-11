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
    public static class CachedFunctions
    {
        public static DbNullable<int> Diagramobjects()
        {
            DbCache.FunctionKey key = new DbCache.FunctionKey("Diagramobjects");
            DbCache.CacheRecord record;
            key.Set();
            if (DbCache.Contains(key))
            {
                record = DbCache.GetRecord(key);
                if (!record.IsValid())
                {
                    record.Value = Functions.Diagramobjects();
                    record.LastUpdate = DateTime.Now;
                    record.Valid = true;
                }
            }
            else
            {
                record = new DbCache.CacheRecord();
                record.Value = Functions.Diagramobjects();
                record.LastUpdate = DateTime.Now;
                record.Valid = true;
                DbCache.SetRecord(key, record);
            }
            return (DbNullable<int>)record.Value;
        }

        public static DbNullable<decimal> FceGetDefaultIFU()
        {
            DbCache.FunctionKey key = new DbCache.FunctionKey("FceGetDefaultIFU");
            DbCache.CacheRecord record;
            key.Set();
            if (DbCache.Contains(key))
            {
                record = DbCache.GetRecord(key);
                if (!record.IsValid())
                {
                    record.Value = Functions.FceGetDefaultIFU();
                    record.LastUpdate = DateTime.Now;
                    record.Valid = true;
                }
            }
            else
            {
                record = new DbCache.CacheRecord();
                record.Value = Functions.FceGetDefaultIFU();
                record.LastUpdate = DateTime.Now;
                record.Valid = true;
                DbCache.SetRecord(key, record);
            }
            return (DbNullable<decimal>)record.Value;
        }

        public static DbNullable<decimal> FceGetDefaultTimeKoef()
        {
            DbCache.FunctionKey key = new DbCache.FunctionKey("FceGetDefaultTimeKoef");
            DbCache.CacheRecord record;
            key.Set();
            if (DbCache.Contains(key))
            {
                record = DbCache.GetRecord(key);
                if (!record.IsValid())
                {
                    record.Value = Functions.FceGetDefaultTimeKoef();
                    record.LastUpdate = DateTime.Now;
                    record.Valid = true;
                }
            }
            else
            {
                record = new DbCache.CacheRecord();
                record.Value = Functions.FceGetDefaultTimeKoef();
                record.LastUpdate = DateTime.Now;
                record.Valid = true;
                DbCache.SetRecord(key, record);
            }
            return (DbNullable<decimal>)record.Value;
        }

        public static DbNullable<decimal> FceGetTotalWeightVyskladneni(DbNullable<int> pKV)
        {
            DbCache.FunctionKey key = new DbCache.FunctionKey("FceGetTotalWeightVyskladneni");
            DbCache.CacheRecord record;
            key.Set(pKV);
            if (DbCache.Contains(key))
            {
                record = DbCache.GetRecord(key);
                if (!record.IsValid())
                {
                    record.Value = Functions.FceGetTotalWeightVyskladneni(pKV);
                    record.LastUpdate = DateTime.Now;
                    record.Valid = true;
                }
            }
            else
            {
                record = new DbCache.CacheRecord();
                record.Value = Functions.FceGetTotalWeightVyskladneni(pKV);
                record.LastUpdate = DateTime.Now;
                record.Valid = true;
                DbCache.SetRecord(key, record);
            }
            return (DbNullable<decimal>)record.Value;
        }

        public static DbNullable<string> FceGetComponentMovementCode(DbNullable<int> movementType)
        {
            DbCache.FunctionKey key = new DbCache.FunctionKey("FceGetComponentMovementCode");
            DbCache.CacheRecord record;
            key.Set(movementType);
            if (DbCache.Contains(key))
            {
                record = DbCache.GetRecord(key);
                if (!record.IsValid())
                {
                    record.Value = Functions.FceGetComponentMovementCode(movementType);
                    record.LastUpdate = DateTime.Now;
                    record.Valid = true;
                }
            }
            else
            {
                record = new DbCache.CacheRecord();
                record.Value = Functions.FceGetComponentMovementCode(movementType);
                record.LastUpdate = DateTime.Now;
                record.Valid = true;
                DbCache.SetRecord(key, record);
            }
            return (DbNullable<string>)record.Value;
        }

        public static DbNullable<string> FceMaterComp(DbNullable<int> iD)
        {
            DbCache.FunctionKey key = new DbCache.FunctionKey("FceMaterComp");
            DbCache.CacheRecord record;
            key.Set(iD);
            if (DbCache.Contains(key))
            {
                record = DbCache.GetRecord(key);
                if (!record.IsValid())
                {
                    record.Value = Functions.FceMaterComp(iD);
                    record.LastUpdate = DateTime.Now;
                    record.Valid = true;
                }
            }
            else
            {
                record = new DbCache.CacheRecord();
                record.Value = Functions.FceMaterComp(iD);
                record.LastUpdate = DateTime.Now;
                record.Valid = true;
                DbCache.SetRecord(key, record);
            }
            return (DbNullable<string>)record.Value;
        }

        public static DbNullable<string> FceUserMSSQL()
        {
            DbCache.FunctionKey key = new DbCache.FunctionKey("FceUserMSSQL");
            DbCache.CacheRecord record;
            key.Set();
            if (DbCache.Contains(key))
            {
                record = DbCache.GetRecord(key);
                if (!record.IsValid())
                {
                    record.Value = Functions.FceUserMSSQL();
                    record.LastUpdate = DateTime.Now;
                    record.Valid = true;
                }
            }
            else
            {
                record = new DbCache.CacheRecord();
                record.Value = Functions.FceUserMSSQL();
                record.LastUpdate = DateTime.Now;
                record.Valid = true;
                DbCache.SetRecord(key, record);
            }
            return (DbNullable<string>)record.Value;
        }

        public static DbNullable<decimal> FceGetIFU_value(DbNullable<int> iFU_type)
        {
            DbCache.FunctionKey key = new DbCache.FunctionKey("FceGetIFU_value");
            DbCache.CacheRecord record;
            key.Set(iFU_type);
            if (DbCache.Contains(key))
            {
                record = DbCache.GetRecord(key);
                if (!record.IsValid())
                {
                    record.Value = Functions.FceGetIFU_value(iFU_type);
                    record.LastUpdate = DateTime.Now;
                    record.Valid = true;
                }
            }
            else
            {
                record = new DbCache.CacheRecord();
                record.Value = Functions.FceGetIFU_value(iFU_type);
                record.LastUpdate = DateTime.Now;
                record.Valid = true;
                DbCache.SetRecord(key, record);
            }
            return (DbNullable<decimal>)record.Value;
        }

        public static DbNullable<string> FcePrmExcelTemp()
        {
            DbCache.FunctionKey key = new DbCache.FunctionKey("FcePrmExcelTemp");
            DbCache.CacheRecord record;
            key.Set();
            if (DbCache.Contains(key))
            {
                record = DbCache.GetRecord(key);
                if (!record.IsValid())
                {
                    record.Value = Functions.FcePrmExcelTemp();
                    record.LastUpdate = DateTime.Now;
                    record.Valid = true;
                }
            }
            else
            {
                record = new DbCache.CacheRecord();
                record.Value = Functions.FcePrmExcelTemp();
                record.LastUpdate = DateTime.Now;
                record.Valid = true;
                DbCache.SetRecord(key, record);
            }
            return (DbNullable<string>)record.Value;
        }

        public static DbNullable<int> FceWorkDays(DbNullable<DateTime> dateFrom, DbNullable<DateTime> dateTill)
        {
            DbCache.FunctionKey key = new DbCache.FunctionKey("FceWorkDays");
            DbCache.CacheRecord record;
            key.Set(dateFrom, dateTill);
            if (DbCache.Contains(key))
            {
                record = DbCache.GetRecord(key);
                if (!record.IsValid())
                {
                    record.Value = Functions.FceWorkDays(dateFrom, dateTill);
                    record.LastUpdate = DateTime.Now;
                    record.Valid = true;
                }
            }
            else
            {
                record = new DbCache.CacheRecord();
                record.Value = Functions.FceWorkDays(dateFrom, dateTill);
                record.LastUpdate = DateTime.Now;
                record.Valid = true;
                DbCache.SetRecord(key, record);
            }
            return (DbNullable<int>)record.Value;
        }
    }
}
