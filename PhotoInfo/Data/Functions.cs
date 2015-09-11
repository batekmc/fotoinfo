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
    public static class Functions
    {
        public static DbNullable<int> Diagramobjects()
        {
            SqlCommand cmdFunction = Session.CreateCommand();

            cmdFunction.CommandText = "SELECT dbo.fn_diagramobjects()";

            object data = cmdFunction.ExecuteScalar();
            if (data == null || data == DBNull.Value)
            {
                return DBNull.Value;
            }
            else
            {
                return DbConverter.ToIntNull(data);
            }
        }

        public static DbNullable<decimal> FceGetDefaultIFU()
        {
            SqlCommand cmdFunction = Session.CreateCommand();

            cmdFunction.CommandText = "SELECT dbo.FceGetDefaultIFU()";

            object data = cmdFunction.ExecuteScalar();
            if (data == null || data == DBNull.Value)
            {
                return DBNull.Value;
            }
            else
            {
                return DbConverter.ToDecimalNull(data);
            }
        }

        public static DbNullable<decimal> FceGetDefaultTimeKoef()
        {
            SqlCommand cmdFunction = Session.CreateCommand();

            cmdFunction.CommandText = "SELECT dbo.FceGetDefaultTimeKoef()";

            object data = cmdFunction.ExecuteScalar();
            if (data == null || data == DBNull.Value)
            {
                return DBNull.Value;
            }
            else
            {
                return DbConverter.ToDecimalNull(data);
            }
        }

        public static DbNullable<decimal> FceGetTotalWeightVyskladneni(DbNullable<int> pKV)
        {
            SqlCommand cmdFunction = Session.CreateCommand();

            cmdFunction.CommandText = "SELECT dbo.FceGetTotalWeightVyskladneni(@PKV)";
            cmdFunction.Parameters.AddWithValue("@PKV", DbConverter.FromIntNull(pKV));

            object data = cmdFunction.ExecuteScalar();
            if (data == null || data == DBNull.Value)
            {
                return DBNull.Value;
            }
            else
            {
                return DbConverter.ToDecimalNull(data);
            }
        }

        public static DbNullable<string> FceGetComponentMovementCode(DbNullable<int> movementType)
        {
            SqlCommand cmdFunction = Session.CreateCommand();

            cmdFunction.CommandText = "SELECT dbo.FceGetComponentMovementCode(@MovementType)";
            cmdFunction.Parameters.AddWithValue("@MovementType", DbConverter.FromIntNull(movementType));

            object data = cmdFunction.ExecuteScalar();
            if (data == null || data == DBNull.Value)
            {
                return DBNull.Value;
            }
            else
            {
                return DbConverter.ToStringNull(data);
            }
        }

        public static DbNullable<string> FceMaterComp(DbNullable<int> iD)
        {
            SqlCommand cmdFunction = Session.CreateCommand();

            cmdFunction.CommandText = "SELECT dbo.FceMaterComp(@ID)";
            cmdFunction.Parameters.AddWithValue("@ID", DbConverter.FromIntNull(iD));

            object data = cmdFunction.ExecuteScalar();
            if (data == null || data == DBNull.Value)
            {
                return DBNull.Value;
            }
            else
            {
                return DbConverter.ToStringNull(data);
            }
        }

        public static DbNullable<string> FceUserMSSQL()
        {
            SqlCommand cmdFunction = Session.CreateCommand();

            cmdFunction.CommandText = "SELECT dbo.FceUserMSSQL()";

            object data = cmdFunction.ExecuteScalar();
            if (data == null || data == DBNull.Value)
            {
                return DBNull.Value;
            }
            else
            {
                return DbConverter.ToStringNull(data);
            }
        }

        public static DbNullable<decimal> FceGetIFU_value(DbNullable<int> iFU_type)
        {
            SqlCommand cmdFunction = Session.CreateCommand();

            cmdFunction.CommandText = "SELECT dbo.FceGetIFU_value(@IFU_type)";
            cmdFunction.Parameters.AddWithValue("@IFU_type", DbConverter.FromIntNull(iFU_type));

            object data = cmdFunction.ExecuteScalar();
            if (data == null || data == DBNull.Value)
            {
                return DBNull.Value;
            }
            else
            {
                return DbConverter.ToDecimalNull(data);
            }
        }

        public static DbNullable<string> FcePrmExcelTemp()
        {
            SqlCommand cmdFunction = Session.CreateCommand();

            cmdFunction.CommandText = "SELECT dbo.FcePrmExcelTemp()";

            object data = cmdFunction.ExecuteScalar();
            if (data == null || data == DBNull.Value)
            {
                return DBNull.Value;
            }
            else
            {
                return DbConverter.ToStringNull(data);
            }
        }

        public static DbNullable<int> FceWorkDays(DbNullable<DateTime> dateFrom, DbNullable<DateTime> dateTill)
        {
            SqlCommand cmdFunction = Session.CreateCommand();

            cmdFunction.CommandText = "SELECT dbo.FceWorkDays(@DateFrom, @DateTill)";
            cmdFunction.Parameters.AddWithValue("@DateFrom", DbConverter.FromDateTimeNull(dateFrom));
            cmdFunction.Parameters.AddWithValue("@DateTill", DbConverter.FromDateTimeNull(dateTill));

            object data = cmdFunction.ExecuteScalar();
            if (data == null || data == DBNull.Value)
            {
                return DBNull.Value;
            }
            else
            {
                return DbConverter.ToIntNull(data);
            }
        }
    }
}
