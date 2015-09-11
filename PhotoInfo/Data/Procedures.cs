using System;
using System.Linq;
using System.Text;
using System.Data;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using SmartISLib;
using SmartISLib.ORM;

namespace PhotoInfo.Data
{
    public static class Procedures
    {
        public static void Dt_getpropertiesbyid_u(DbNullable<int> id, DbNullable<string> property)
        {
            SqlCommand cmdProcedure = Session.CreateCommand();

            cmdProcedure.CommandText = "dbo.dt_getpropertiesbyid_u";
            cmdProcedure.CommandType = CommandType.StoredProcedure;
            cmdProcedure.Parameters.AddWithValue("@id", DbConverter.FromIntNull(id));
            cmdProcedure.Parameters.AddWithValue("@property", DbConverter.FromStringNull(property));

            cmdProcedure.ExecuteNonQuery();
        }

        public static void Dt_dropuserobjectbyid(DbNullable<int> id)
        {
            SqlCommand cmdProcedure = Session.CreateCommand();

            cmdProcedure.CommandText = "dbo.dt_dropuserobjectbyid";
            cmdProcedure.CommandType = CommandType.StoredProcedure;
            cmdProcedure.Parameters.AddWithValue("@id", DbConverter.FromIntNull(id));

            cmdProcedure.ExecuteNonQuery();
        }

        public static void Dt_droppropertiesbyid(DbNullable<int> id, DbNullable<string> property)
        {
            SqlCommand cmdProcedure = Session.CreateCommand();

            cmdProcedure.CommandText = "dbo.dt_droppropertiesbyid";
            cmdProcedure.CommandType = CommandType.StoredProcedure;
            cmdProcedure.Parameters.AddWithValue("@id", DbConverter.FromIntNull(id));
            cmdProcedure.Parameters.AddWithValue("@property", DbConverter.FromStringNull(property));

            cmdProcedure.ExecuteNonQuery();
        }

        public static void Dt_verstamp006()
        {
            SqlCommand cmdProcedure = Session.CreateCommand();

            cmdProcedure.CommandText = "dbo.dt_verstamp006";
            cmdProcedure.CommandType = CommandType.StoredProcedure;

            cmdProcedure.ExecuteNonQuery();
        }

        public static void Dt_verstamp007()
        {
            SqlCommand cmdProcedure = Session.CreateCommand();

            cmdProcedure.CommandText = "dbo.dt_verstamp007";
            cmdProcedure.CommandType = CommandType.StoredProcedure;

            cmdProcedure.ExecuteNonQuery();
        }

        public static void Dt_displayoaerror(DbNullable<int> iObject, DbNullable<int> iresult)
        {
            SqlCommand cmdProcedure = Session.CreateCommand();

            cmdProcedure.CommandText = "dbo.dt_displayoaerror";
            cmdProcedure.CommandType = CommandType.StoredProcedure;
            cmdProcedure.Parameters.AddWithValue("@iObject", DbConverter.FromIntNull(iObject));
            cmdProcedure.Parameters.AddWithValue("@iresult", DbConverter.FromIntNull(iresult));

            cmdProcedure.ExecuteNonQuery();
        }

        public static void Dt_adduserobject_vcs(DbNullable<string> vchProperty)
        {
            SqlCommand cmdProcedure = Session.CreateCommand();

            cmdProcedure.CommandText = "dbo.dt_adduserobject_vcs";
            cmdProcedure.CommandType = CommandType.StoredProcedure;
            cmdProcedure.Parameters.AddWithValue("@vchProperty", DbConverter.FromStringNull(vchProperty));

            cmdProcedure.ExecuteNonQuery();
        }

        public static void SPImport()
        {
            SqlCommand cmdProcedure = Session.CreateCommand();

            cmdProcedure.CommandText = "dbo.SPImport";
            cmdProcedure.CommandType = CommandType.StoredProcedure;

            cmdProcedure.ExecuteNonQuery();
        }

        public static void Dt_addtosourcecontrol(DbNullable<string> vchSourceSafeINI, DbNullable<string> vchProjectName, DbNullable<string> vchComment, DbNullable<string> vchLoginName, DbNullable<string> vchPassword)
        {
            SqlCommand cmdProcedure = Session.CreateCommand();

            cmdProcedure.CommandText = "dbo.dt_addtosourcecontrol";
            cmdProcedure.CommandType = CommandType.StoredProcedure;
            cmdProcedure.Parameters.AddWithValue("@vchSourceSafeINI", DbConverter.FromStringNull(vchSourceSafeINI));
            cmdProcedure.Parameters.AddWithValue("@vchProjectName", DbConverter.FromStringNull(vchProjectName));
            cmdProcedure.Parameters.AddWithValue("@vchComment", DbConverter.FromStringNull(vchComment));
            cmdProcedure.Parameters.AddWithValue("@vchLoginName", DbConverter.FromStringNull(vchLoginName));
            cmdProcedure.Parameters.AddWithValue("@vchPassword", DbConverter.FromStringNull(vchPassword));

            cmdProcedure.ExecuteNonQuery();
        }

        public static void Dt_checkinobject(DbNullable<string> chObjectType, DbNullable<string> vchObjectName, DbNullable<string> vchComment, DbNullable<string> vchLoginName, DbNullable<string> vchPassword, DbNullable<int> iVCSFlags, DbNullable<int> iActionFlag, DbNullable<string> txStream1, DbNullable<string> txStream2, DbNullable<string> txStream3)
        {
            SqlCommand cmdProcedure = Session.CreateCommand();

            cmdProcedure.CommandText = "dbo.dt_checkinobject";
            cmdProcedure.CommandType = CommandType.StoredProcedure;
            cmdProcedure.Parameters.AddWithValue("@chObjectType", DbConverter.FromStringNull(chObjectType));
            cmdProcedure.Parameters.AddWithValue("@vchObjectName", DbConverter.FromStringNull(vchObjectName));
            cmdProcedure.Parameters.AddWithValue("@vchComment", DbConverter.FromStringNull(vchComment));
            cmdProcedure.Parameters.AddWithValue("@vchLoginName", DbConverter.FromStringNull(vchLoginName));
            cmdProcedure.Parameters.AddWithValue("@vchPassword", DbConverter.FromStringNull(vchPassword));
            cmdProcedure.Parameters.AddWithValue("@iVCSFlags", DbConverter.FromIntNull(iVCSFlags));
            cmdProcedure.Parameters.AddWithValue("@iActionFlag", DbConverter.FromIntNull(iActionFlag));
            cmdProcedure.Parameters.AddWithValue("@txStream1", DbConverter.FromStringNull(txStream1));
            cmdProcedure.Parameters.AddWithValue("@txStream2", DbConverter.FromStringNull(txStream2));
            cmdProcedure.Parameters.AddWithValue("@txStream3", DbConverter.FromStringNull(txStream3));

            cmdProcedure.ExecuteNonQuery();
        }

        public static void Dt_checkoutobject(DbNullable<string> chObjectType, DbNullable<string> vchObjectName, DbNullable<string> vchComment, DbNullable<string> vchLoginName, DbNullable<string> vchPassword, DbNullable<int> iVCSFlags, DbNullable<int> iActionFlag)
        {
            SqlCommand cmdProcedure = Session.CreateCommand();

            cmdProcedure.CommandText = "dbo.dt_checkoutobject";
            cmdProcedure.CommandType = CommandType.StoredProcedure;
            cmdProcedure.Parameters.AddWithValue("@chObjectType", DbConverter.FromStringNull(chObjectType));
            cmdProcedure.Parameters.AddWithValue("@vchObjectName", DbConverter.FromStringNull(vchObjectName));
            cmdProcedure.Parameters.AddWithValue("@vchComment", DbConverter.FromStringNull(vchComment));
            cmdProcedure.Parameters.AddWithValue("@vchLoginName", DbConverter.FromStringNull(vchLoginName));
            cmdProcedure.Parameters.AddWithValue("@vchPassword", DbConverter.FromStringNull(vchPassword));
            cmdProcedure.Parameters.AddWithValue("@iVCSFlags", DbConverter.FromIntNull(iVCSFlags));
            cmdProcedure.Parameters.AddWithValue("@iActionFlag", DbConverter.FromIntNull(iActionFlag));

            cmdProcedure.ExecuteNonQuery();
        }

        public static void Dt_isundersourcecontrol(DbNullable<string> vchLoginName, DbNullable<string> vchPassword, DbNullable<int> iWhoToo)
        {
            SqlCommand cmdProcedure = Session.CreateCommand();

            cmdProcedure.CommandText = "dbo.dt_isundersourcecontrol";
            cmdProcedure.CommandType = CommandType.StoredProcedure;
            cmdProcedure.Parameters.AddWithValue("@vchLoginName", DbConverter.FromStringNull(vchLoginName));
            cmdProcedure.Parameters.AddWithValue("@vchPassword", DbConverter.FromStringNull(vchPassword));
            cmdProcedure.Parameters.AddWithValue("@iWhoToo", DbConverter.FromIntNull(iWhoToo));

            cmdProcedure.ExecuteNonQuery();
        }

        public static void Dt_removefromsourcecontrol()
        {
            SqlCommand cmdProcedure = Session.CreateCommand();

            cmdProcedure.CommandText = "dbo.dt_removefromsourcecontrol";
            cmdProcedure.CommandType = CommandType.StoredProcedure;

            cmdProcedure.ExecuteNonQuery();
        }

        public static void Dt_validateloginparams(DbNullable<string> vchLoginName, DbNullable<string> vchPassword)
        {
            SqlCommand cmdProcedure = Session.CreateCommand();

            cmdProcedure.CommandText = "dbo.dt_validateloginparams";
            cmdProcedure.CommandType = CommandType.StoredProcedure;
            cmdProcedure.Parameters.AddWithValue("@vchLoginName", DbConverter.FromStringNull(vchLoginName));
            cmdProcedure.Parameters.AddWithValue("@vchPassword", DbConverter.FromStringNull(vchPassword));

            cmdProcedure.ExecuteNonQuery();
        }

        public static void Upgraddiagrams()
        {
            SqlCommand cmdProcedure = Session.CreateCommand();

            cmdProcedure.CommandText = "dbo.sp_upgraddiagrams";
            cmdProcedure.CommandType = CommandType.StoredProcedure;

            cmdProcedure.ExecuteNonQuery();
        }

        public static void Dt_vcsenabled()
        {
            SqlCommand cmdProcedure = Session.CreateCommand();

            cmdProcedure.CommandText = "dbo.dt_vcsenabled";
            cmdProcedure.CommandType = CommandType.StoredProcedure;

            cmdProcedure.ExecuteNonQuery();
        }

        public static void Dt_whocheckedout(DbNullable<string> chObjectType, DbNullable<string> vchObjectName, DbNullable<string> vchLoginName, DbNullable<string> vchPassword)
        {
            SqlCommand cmdProcedure = Session.CreateCommand();

            cmdProcedure.CommandText = "dbo.dt_whocheckedout";
            cmdProcedure.CommandType = CommandType.StoredProcedure;
            cmdProcedure.Parameters.AddWithValue("@chObjectType", DbConverter.FromStringNull(chObjectType));
            cmdProcedure.Parameters.AddWithValue("@vchObjectName", DbConverter.FromStringNull(vchObjectName));
            cmdProcedure.Parameters.AddWithValue("@vchLoginName", DbConverter.FromStringNull(vchLoginName));
            cmdProcedure.Parameters.AddWithValue("@vchPassword", DbConverter.FromStringNull(vchPassword));

            cmdProcedure.ExecuteNonQuery();
        }

        public static void Dt_displayoaerror_u(DbNullable<int> iObject, DbNullable<int> iresult)
        {
            SqlCommand cmdProcedure = Session.CreateCommand();

            cmdProcedure.CommandText = "dbo.dt_displayoaerror_u";
            cmdProcedure.CommandType = CommandType.StoredProcedure;
            cmdProcedure.Parameters.AddWithValue("@iObject", DbConverter.FromIntNull(iObject));
            cmdProcedure.Parameters.AddWithValue("@iresult", DbConverter.FromIntNull(iresult));

            cmdProcedure.ExecuteNonQuery();
        }

        public static void SPIdentityNew(DbNullable<string> sQLText)
        {
            SqlCommand cmdProcedure = Session.CreateCommand();

            cmdProcedure.CommandText = "dbo.SPIdentityNew";
            cmdProcedure.CommandType = CommandType.StoredProcedure;
            cmdProcedure.Parameters.AddWithValue("@SQLText", DbConverter.FromStringNull(sQLText));

            cmdProcedure.ExecuteNonQuery();
        }

        public static void Dt_addtosourcecontrol_u(DbNullable<string> vchSourceSafeINI, DbNullable<string> vchProjectName, DbNullable<string> vchComment, DbNullable<string> vchLoginName, DbNullable<string> vchPassword)
        {
            SqlCommand cmdProcedure = Session.CreateCommand();

            cmdProcedure.CommandText = "dbo.dt_addtosourcecontrol_u";
            cmdProcedure.CommandType = CommandType.StoredProcedure;
            cmdProcedure.Parameters.AddWithValue("@vchSourceSafeINI", DbConverter.FromStringNull(vchSourceSafeINI));
            cmdProcedure.Parameters.AddWithValue("@vchProjectName", DbConverter.FromStringNull(vchProjectName));
            cmdProcedure.Parameters.AddWithValue("@vchComment", DbConverter.FromStringNull(vchComment));
            cmdProcedure.Parameters.AddWithValue("@vchLoginName", DbConverter.FromStringNull(vchLoginName));
            cmdProcedure.Parameters.AddWithValue("@vchPassword", DbConverter.FromStringNull(vchPassword));

            cmdProcedure.ExecuteNonQuery();
        }

        public static void Dt_checkinobject_u(DbNullable<string> chObjectType, DbNullable<string> vchObjectName, DbNullable<string> vchComment, DbNullable<string> vchLoginName, DbNullable<string> vchPassword, DbNullable<int> iVCSFlags, DbNullable<int> iActionFlag, DbNullable<string> txStream1, DbNullable<string> txStream2, DbNullable<string> txStream3)
        {
            SqlCommand cmdProcedure = Session.CreateCommand();

            cmdProcedure.CommandText = "dbo.dt_checkinobject_u";
            cmdProcedure.CommandType = CommandType.StoredProcedure;
            cmdProcedure.Parameters.AddWithValue("@chObjectType", DbConverter.FromStringNull(chObjectType));
            cmdProcedure.Parameters.AddWithValue("@vchObjectName", DbConverter.FromStringNull(vchObjectName));
            cmdProcedure.Parameters.AddWithValue("@vchComment", DbConverter.FromStringNull(vchComment));
            cmdProcedure.Parameters.AddWithValue("@vchLoginName", DbConverter.FromStringNull(vchLoginName));
            cmdProcedure.Parameters.AddWithValue("@vchPassword", DbConverter.FromStringNull(vchPassword));
            cmdProcedure.Parameters.AddWithValue("@iVCSFlags", DbConverter.FromIntNull(iVCSFlags));
            cmdProcedure.Parameters.AddWithValue("@iActionFlag", DbConverter.FromIntNull(iActionFlag));
            cmdProcedure.Parameters.AddWithValue("@txStream1", DbConverter.FromStringNull(txStream1));
            cmdProcedure.Parameters.AddWithValue("@txStream2", DbConverter.FromStringNull(txStream2));
            cmdProcedure.Parameters.AddWithValue("@txStream3", DbConverter.FromStringNull(txStream3));

            cmdProcedure.ExecuteNonQuery();
        }

        public static void Helpdiagrams(DbNullable<string> diagramname, DbNullable<int> owner_id)
        {
            SqlCommand cmdProcedure = Session.CreateCommand();

            cmdProcedure.CommandText = "dbo.sp_helpdiagrams";
            cmdProcedure.CommandType = CommandType.StoredProcedure;
            cmdProcedure.Parameters.AddWithValue("@diagramname", DbConverter.FromStringNull(diagramname));
            cmdProcedure.Parameters.AddWithValue("@owner_id", DbConverter.FromIntNull(owner_id));

            cmdProcedure.ExecuteNonQuery();
        }

        public static void Dt_checkoutobject_u(DbNullable<string> chObjectType, DbNullable<string> vchObjectName, DbNullable<string> vchComment, DbNullable<string> vchLoginName, DbNullable<string> vchPassword, DbNullable<int> iVCSFlags, DbNullable<int> iActionFlag)
        {
            SqlCommand cmdProcedure = Session.CreateCommand();

            cmdProcedure.CommandText = "dbo.dt_checkoutobject_u";
            cmdProcedure.CommandType = CommandType.StoredProcedure;
            cmdProcedure.Parameters.AddWithValue("@chObjectType", DbConverter.FromStringNull(chObjectType));
            cmdProcedure.Parameters.AddWithValue("@vchObjectName", DbConverter.FromStringNull(vchObjectName));
            cmdProcedure.Parameters.AddWithValue("@vchComment", DbConverter.FromStringNull(vchComment));
            cmdProcedure.Parameters.AddWithValue("@vchLoginName", DbConverter.FromStringNull(vchLoginName));
            cmdProcedure.Parameters.AddWithValue("@vchPassword", DbConverter.FromStringNull(vchPassword));
            cmdProcedure.Parameters.AddWithValue("@iVCSFlags", DbConverter.FromIntNull(iVCSFlags));
            cmdProcedure.Parameters.AddWithValue("@iActionFlag", DbConverter.FromIntNull(iActionFlag));

            cmdProcedure.ExecuteNonQuery();
        }

        public static void Helpdiagramdefinition(DbNullable<string> diagramname, DbNullable<int> owner_id)
        {
            SqlCommand cmdProcedure = Session.CreateCommand();

            cmdProcedure.CommandText = "dbo.sp_helpdiagramdefinition";
            cmdProcedure.CommandType = CommandType.StoredProcedure;
            cmdProcedure.Parameters.AddWithValue("@diagramname", DbConverter.FromStringNull(diagramname));
            cmdProcedure.Parameters.AddWithValue("@owner_id", DbConverter.FromIntNull(owner_id));

            cmdProcedure.ExecuteNonQuery();
        }

        public static void Dt_isundersourcecontrol_u(DbNullable<string> vchLoginName, DbNullable<string> vchPassword, DbNullable<int> iWhoToo)
        {
            SqlCommand cmdProcedure = Session.CreateCommand();

            cmdProcedure.CommandText = "dbo.dt_isundersourcecontrol_u";
            cmdProcedure.CommandType = CommandType.StoredProcedure;
            cmdProcedure.Parameters.AddWithValue("@vchLoginName", DbConverter.FromStringNull(vchLoginName));
            cmdProcedure.Parameters.AddWithValue("@vchPassword", DbConverter.FromStringNull(vchPassword));
            cmdProcedure.Parameters.AddWithValue("@iWhoToo", DbConverter.FromIntNull(iWhoToo));

            cmdProcedure.ExecuteNonQuery();
        }

        public static void Dt_validateloginparams_u(DbNullable<string> vchLoginName, DbNullable<string> vchPassword)
        {
            SqlCommand cmdProcedure = Session.CreateCommand();

            cmdProcedure.CommandText = "dbo.dt_validateloginparams_u";
            cmdProcedure.CommandType = CommandType.StoredProcedure;
            cmdProcedure.Parameters.AddWithValue("@vchLoginName", DbConverter.FromStringNull(vchLoginName));
            cmdProcedure.Parameters.AddWithValue("@vchPassword", DbConverter.FromStringNull(vchPassword));

            cmdProcedure.ExecuteNonQuery();
        }

        public static void Renamediagram(DbNullable<string> diagramname, DbNullable<int> owner_id, DbNullable<string> new_diagramname)
        {
            SqlCommand cmdProcedure = Session.CreateCommand();

            cmdProcedure.CommandText = "dbo.sp_renamediagram";
            cmdProcedure.CommandType = CommandType.StoredProcedure;
            cmdProcedure.Parameters.AddWithValue("@diagramname", DbConverter.FromStringNull(diagramname));
            cmdProcedure.Parameters.AddWithValue("@owner_id", DbConverter.FromIntNull(owner_id));
            cmdProcedure.Parameters.AddWithValue("@new_diagramname", DbConverter.FromStringNull(new_diagramname));

            cmdProcedure.ExecuteNonQuery();
        }

        public static void Dt_whocheckedout_u(DbNullable<string> chObjectType, DbNullable<string> vchObjectName, DbNullable<string> vchLoginName, DbNullable<string> vchPassword)
        {
            SqlCommand cmdProcedure = Session.CreateCommand();

            cmdProcedure.CommandText = "dbo.dt_whocheckedout_u";
            cmdProcedure.CommandType = CommandType.StoredProcedure;
            cmdProcedure.Parameters.AddWithValue("@chObjectType", DbConverter.FromStringNull(chObjectType));
            cmdProcedure.Parameters.AddWithValue("@vchObjectName", DbConverter.FromStringNull(vchObjectName));
            cmdProcedure.Parameters.AddWithValue("@vchLoginName", DbConverter.FromStringNull(vchLoginName));
            cmdProcedure.Parameters.AddWithValue("@vchPassword", DbConverter.FromStringNull(vchPassword));

            cmdProcedure.ExecuteNonQuery();
        }

        public static void Dropdiagram(DbNullable<string> diagramname, DbNullable<int> owner_id)
        {
            SqlCommand cmdProcedure = Session.CreateCommand();

            cmdProcedure.CommandText = "dbo.sp_dropdiagram";
            cmdProcedure.CommandType = CommandType.StoredProcedure;
            cmdProcedure.Parameters.AddWithValue("@diagramname", DbConverter.FromStringNull(diagramname));
            cmdProcedure.Parameters.AddWithValue("@owner_id", DbConverter.FromIntNull(owner_id));

            cmdProcedure.ExecuteNonQuery();
        }

        public static void SPSampleListUpdate(DbNullable<string> cisloSetu)
        {
            SqlCommand cmdProcedure = Session.CreateCommand();

            cmdProcedure.CommandText = "dbo.SPSampleListUpdate";
            cmdProcedure.CommandType = CommandType.StoredProcedure;
            cmdProcedure.Parameters.AddWithValue("@CisloSetu", DbConverter.FromStringNull(cisloSetu));

            cmdProcedure.ExecuteNonQuery();
        }

        public static void SPComponentMasterInsert()
        {
            SqlCommand cmdProcedure = Session.CreateCommand();

            cmdProcedure.CommandText = "dbo.SPComponentMasterInsert";
            cmdProcedure.CommandType = CommandType.StoredProcedure;

            cmdProcedure.ExecuteNonQuery();
        }

        public static void SPComponentImport()
        {
            SqlCommand cmdProcedure = Session.CreateCommand();

            cmdProcedure.CommandText = "dbo.SPComponentImport";
            cmdProcedure.CommandType = CommandType.StoredProcedure;

            cmdProcedure.ExecuteNonQuery();
        }

        public static void SPComponentExcelImport()
        {
            SqlCommand cmdProcedure = Session.CreateCommand();

            cmdProcedure.CommandText = "dbo.SPComponentExcelImport";
            cmdProcedure.CommandType = CommandType.StoredProcedure;

            cmdProcedure.ExecuteNonQuery();
        }

        public static void SPUpdateNewDataComponent()
        {
            SqlCommand cmdProcedure = Session.CreateCommand();

            cmdProcedure.CommandText = "dbo.SPUpdateNewDataComponent";
            cmdProcedure.CommandType = CommandType.StoredProcedure;

            cmdProcedure.ExecuteNonQuery();
        }

        public static void SPUpdateQDateResiduals()
        {
            SqlCommand cmdProcedure = Session.CreateCommand();

            cmdProcedure.CommandText = "dbo.SPUpdateQDateResiduals";
            cmdProcedure.CommandType = CommandType.StoredProcedure;

            cmdProcedure.ExecuteNonQuery();
        }

        public static void SPResyncComponentDetail(DbNullable<int> id)
        {
            SqlCommand cmdProcedure = Session.CreateCommand();

            cmdProcedure.CommandText = "dbo.SPResyncComponentDetail";
            cmdProcedure.CommandType = CommandType.StoredProcedure;
            cmdProcedure.Parameters.AddWithValue("@id", DbConverter.FromIntNull(id));

            cmdProcedure.ExecuteNonQuery();
        }

        public static void StoredProcedureImportCompAll()
        {
            SqlCommand cmdProcedure = Session.CreateCommand();

            cmdProcedure.CommandText = "dbo.StoredProcedureImportCompAll";
            cmdProcedure.CommandType = CommandType.StoredProcedure;

            cmdProcedure.ExecuteNonQuery();
        }

        public static void SPComplaintInsert()
        {
            SqlCommand cmdProcedure = Session.CreateCommand();

            cmdProcedure.CommandText = "dbo.SPComplaintInsert";
            cmdProcedure.CommandType = CommandType.StoredProcedure;

            cmdProcedure.ExecuteNonQuery();
        }

        public static void _SPImport()
        {
            SqlCommand cmdProcedure = Session.CreateCommand();

            cmdProcedure.CommandText = "dbo._SPImport";
            cmdProcedure.CommandType = CommandType.StoredProcedure;

            cmdProcedure.ExecuteNonQuery();
        }

        public static void SPResyncComplaintDetail(DbNullable<int> id)
        {
            SqlCommand cmdProcedure = Session.CreateCommand();

            cmdProcedure.CommandText = "dbo.SPResyncComplaintDetail";
            cmdProcedure.CommandType = CommandType.StoredProcedure;
            cmdProcedure.Parameters.AddWithValue("@id", DbConverter.FromIntNull(id));

            cmdProcedure.ExecuteNonQuery();
        }

        public static void SPTimesRevisionNew(DbNullable<int> revisionID, DbNullable<int> componentID)
        {
            SqlCommand cmdProcedure = Session.CreateCommand();

            cmdProcedure.CommandText = "dbo.SPTimesRevisionNew";
            cmdProcedure.CommandType = CommandType.StoredProcedure;
            cmdProcedure.Parameters.AddWithValue("@RevisionID", DbConverter.FromIntNull(revisionID));
            cmdProcedure.Parameters.AddWithValue("@ComponentID", DbConverter.FromIntNull(componentID));

            cmdProcedure.ExecuteNonQuery();
        }

        public static void SPTimesRevisionDetailNew(DbNullable<int> iD, DbNullable<int> newID)
        {
            SqlCommand cmdProcedure = Session.CreateCommand();

            cmdProcedure.CommandText = "dbo.SPTimesRevisionDetailNew";
            cmdProcedure.CommandType = CommandType.StoredProcedure;
            cmdProcedure.Parameters.AddWithValue("@ID", DbConverter.FromIntNull(iD));
            cmdProcedure.Parameters.AddWithValue("@NewID", DbConverter.FromIntNull(newID));

            cmdProcedure.ExecuteNonQuery();
        }

        public static void SPIdentity()
        {
            SqlCommand cmdProcedure = Session.CreateCommand();

            cmdProcedure.CommandText = "dbo.SPIdentity";
            cmdProcedure.CommandType = CommandType.StoredProcedure;

            cmdProcedure.ExecuteNonQuery();
        }

        public static void SPResyncTimesRevisionDetail_sub(DbNullable<int> id)
        {
            SqlCommand cmdProcedure = Session.CreateCommand();

            cmdProcedure.CommandText = "dbo.SPResyncTimesRevisionDetail_sub";
            cmdProcedure.CommandType = CommandType.StoredProcedure;
            cmdProcedure.Parameters.AddWithValue("@id", DbConverter.FromIntNull(id));

            cmdProcedure.ExecuteNonQuery();
        }

        public static void SPTimesRevisionUpdateMainRevision(DbNullable<int> newID)
        {
            SqlCommand cmdProcedure = Session.CreateCommand();

            cmdProcedure.CommandText = "dbo.SPTimesRevisionUpdateMainRevision";
            cmdProcedure.CommandType = CommandType.StoredProcedure;
            cmdProcedure.Parameters.AddWithValue("@NewID", DbConverter.FromIntNull(newID));

            cmdProcedure.ExecuteNonQuery();
        }

        public static void StoredprocedureImportXLS()
        {
            SqlCommand cmdProcedure = Session.CreateCommand();

            cmdProcedure.CommandText = "dbo.StoredprocedureImportXLS";
            cmdProcedure.CommandType = CommandType.StoredProcedure;

            cmdProcedure.ExecuteNonQuery();
        }

        public static void SPUpdateWeightSampleList(DbNullable<int> pKV)
        {
            SqlCommand cmdProcedure = Session.CreateCommand();

            cmdProcedure.CommandText = "dbo.SPUpdateWeightSampleList";
            cmdProcedure.CommandType = CommandType.StoredProcedure;
            cmdProcedure.Parameters.AddWithValue("@PKV", DbConverter.FromIntNull(pKV));

            cmdProcedure.ExecuteNonQuery();
        }

        public static void SPTimesRevisionDetailUpd(DbNullable<int> iD)
        {
            SqlCommand cmdProcedure = Session.CreateCommand();

            cmdProcedure.CommandText = "dbo.SPTimesRevisionDetailUpd";
            cmdProcedure.CommandType = CommandType.StoredProcedure;
            cmdProcedure.Parameters.AddWithValue("@ID", DbConverter.FromIntNull(iD));

            cmdProcedure.ExecuteNonQuery();
        }

        public static void SPTimesRevisionDetailClear(DbNullable<int> iD)
        {
            SqlCommand cmdProcedure = Session.CreateCommand();

            cmdProcedure.CommandText = "dbo.SPTimesRevisionDetailClear";
            cmdProcedure.CommandType = CommandType.StoredProcedure;
            cmdProcedure.Parameters.AddWithValue("@ID", DbConverter.FromIntNull(iD));

            cmdProcedure.ExecuteNonQuery();
        }

        public static void SPComponentTimesRevisionUpd(DbNullable<int> component)
        {
            SqlCommand cmdProcedure = Session.CreateCommand();

            cmdProcedure.CommandText = "dbo.SPComponentTimesRevisionUpd";
            cmdProcedure.CommandType = CommandType.StoredProcedure;
            cmdProcedure.Parameters.AddWithValue("@Component", DbConverter.FromIntNull(component));

            cmdProcedure.ExecuteNonQuery();
        }

        public static void SPDenniPlanUpdateComponent2()
        {
            SqlCommand cmdProcedure = Session.CreateCommand();

            cmdProcedure.CommandText = "dbo.SPDenniPlanUpdateComponent2";
            cmdProcedure.CommandType = CommandType.StoredProcedure;

            cmdProcedure.ExecuteNonQuery();
        }

        public static void SPDenniPlanInsertComponent2()
        {
            SqlCommand cmdProcedure = Session.CreateCommand();

            cmdProcedure.CommandText = "dbo.SPDenniPlanInsertComponent2";
            cmdProcedure.CommandType = CommandType.StoredProcedure;

            cmdProcedure.ExecuteNonQuery();
        }

        public static void SPUpdateComponentDenniPlan()
        {
            SqlCommand cmdProcedure = Session.CreateCommand();

            cmdProcedure.CommandText = "dbo.SPUpdateComponentDenniPlan";
            cmdProcedure.CommandType = CommandType.StoredProcedure;

            cmdProcedure.ExecuteNonQuery();
        }

        public static void SPImportDenniPlan()
        {
            SqlCommand cmdProcedure = Session.CreateCommand();

            cmdProcedure.CommandText = "dbo.SPImportDenniPlan";
            cmdProcedure.CommandType = CommandType.StoredProcedure;

            cmdProcedure.ExecuteNonQuery();
        }

        public static void SPUpdateWeightPKV(DbNullable<int> pKV)
        {
            SqlCommand cmdProcedure = Session.CreateCommand();

            cmdProcedure.CommandText = "dbo.SPUpdateWeightPKV";
            cmdProcedure.CommandType = CommandType.StoredProcedure;
            cmdProcedure.Parameters.AddWithValue("@PKV", DbConverter.FromIntNull(pKV));

            cmdProcedure.ExecuteNonQuery();
        }

        public static void StoredProcedureImportComp()
        {
            SqlCommand cmdProcedure = Session.CreateCommand();

            cmdProcedure.CommandText = "dbo.StoredProcedureImportComp";
            cmdProcedure.CommandType = CommandType.StoredProcedure;

            cmdProcedure.ExecuteNonQuery();
        }

        public static void SPComponentImport2()
        {
            SqlCommand cmdProcedure = Session.CreateCommand();

            cmdProcedure.CommandText = "dbo.SPComponentImport2";
            cmdProcedure.CommandType = CommandType.StoredProcedure;

            cmdProcedure.ExecuteNonQuery();
        }

        public static void SPUpdateWeightSampleListAll()
        {
            SqlCommand cmdProcedure = Session.CreateCommand();

            cmdProcedure.CommandText = "dbo.SPUpdateWeightSampleListAll";
            cmdProcedure.CommandType = CommandType.StoredProcedure;

            cmdProcedure.ExecuteNonQuery();
        }

        public static void SPComponentMasterInsert2()
        {
            SqlCommand cmdProcedure = Session.CreateCommand();

            cmdProcedure.CommandText = "dbo.SPComponentMasterInsert2";
            cmdProcedure.CommandType = CommandType.StoredProcedure;

            cmdProcedure.ExecuteNonQuery();
        }

        public static void SPDeleteBatchDocHistoryEmptyRows()
        {
            SqlCommand cmdProcedure = Session.CreateCommand();

            cmdProcedure.CommandText = "dbo.SPDeleteBatchDocHistoryEmptyRows";
            cmdProcedure.CommandType = CommandType.StoredProcedure;

            cmdProcedure.ExecuteNonQuery();
        }

        public static void SPComponentExcelImport2()
        {
            SqlCommand cmdProcedure = Session.CreateCommand();

            cmdProcedure.CommandText = "dbo.SPComponentExcelImport2";
            cmdProcedure.CommandType = CommandType.StoredProcedure;

            cmdProcedure.ExecuteNonQuery();
        }

        public static void _SPComponentMasterInsert2Bad()
        {
            SqlCommand cmdProcedure = Session.CreateCommand();

            cmdProcedure.CommandText = "dbo._SPComponentMasterInsert2Bad";
            cmdProcedure.CommandType = CommandType.StoredProcedure;

            cmdProcedure.ExecuteNonQuery();
        }

        public static void QComplaintHistory(DbNullable<int> iD)
        {
            SqlCommand cmdProcedure = Session.CreateCommand();

            cmdProcedure.CommandText = "dbo.QComplaintHistory";
            cmdProcedure.CommandType = CommandType.StoredProcedure;
            cmdProcedure.Parameters.AddWithValue("@ID", DbConverter.FromIntNull(iD));

            cmdProcedure.ExecuteNonQuery();
        }

        public static void SPComponentTimesRevisionUpd2(DbNullable<int> component)
        {
            SqlCommand cmdProcedure = Session.CreateCommand();

            cmdProcedure.CommandText = "dbo.SPComponentTimesRevisionUpd2";
            cmdProcedure.CommandType = CommandType.StoredProcedure;
            cmdProcedure.Parameters.AddWithValue("@Component", DbConverter.FromIntNull(component));

            cmdProcedure.ExecuteNonQuery();
        }

        public static void _SPExcelImport()
        {
            SqlCommand cmdProcedure = Session.CreateCommand();

            cmdProcedure.CommandText = "dbo._SPExcelImport";
            cmdProcedure.CommandType = CommandType.StoredProcedure;

            cmdProcedure.ExecuteNonQuery();
        }

        public static void SPBatchDetailImp()
        {
            SqlCommand cmdProcedure = Session.CreateCommand();

            cmdProcedure.CommandText = "dbo.SPBatchDetailImp";
            cmdProcedure.CommandType = CommandType.StoredProcedure;

            cmdProcedure.ExecuteNonQuery();
        }

        public static void SPBatchImp()
        {
            SqlCommand cmdProcedure = Session.CreateCommand();

            cmdProcedure.CommandText = "dbo.SPBatchImp";
            cmdProcedure.CommandType = CommandType.StoredProcedure;

            cmdProcedure.ExecuteNonQuery();
        }

        public static void Dt_adduserobject()
        {
            SqlCommand cmdProcedure = Session.CreateCommand();

            cmdProcedure.CommandText = "dbo.dt_adduserobject";
            cmdProcedure.CommandType = CommandType.StoredProcedure;

            cmdProcedure.ExecuteNonQuery();
        }

        public static void Dt_setpropertybyid(DbNullable<int> id, DbNullable<string> property, DbNullable<string> value, DbNullable<byte[]> lvalue)
        {
            SqlCommand cmdProcedure = Session.CreateCommand();

            cmdProcedure.CommandText = "dbo.dt_setpropertybyid";
            cmdProcedure.CommandType = CommandType.StoredProcedure;
            cmdProcedure.Parameters.AddWithValue("@id", DbConverter.FromIntNull(id));
            cmdProcedure.Parameters.AddWithValue("@property", DbConverter.FromStringNull(property));
            cmdProcedure.Parameters.AddWithValue("@value", DbConverter.FromStringNull(value));
            cmdProcedure.Parameters.AddWithValue("@lvalue", DbConverter.FromArrayNull(lvalue));

            cmdProcedure.ExecuteNonQuery();
        }

        public static void Dt_getobjwithprop(DbNullable<string> property, DbNullable<string> value)
        {
            SqlCommand cmdProcedure = Session.CreateCommand();

            cmdProcedure.CommandText = "dbo.dt_getobjwithprop";
            cmdProcedure.CommandType = CommandType.StoredProcedure;
            cmdProcedure.Parameters.AddWithValue("@property", DbConverter.FromStringNull(property));
            cmdProcedure.Parameters.AddWithValue("@value", DbConverter.FromStringNull(value));

            cmdProcedure.ExecuteNonQuery();
        }

        public static void Dt_getpropertiesbyid(DbNullable<int> id, DbNullable<string> property)
        {
            SqlCommand cmdProcedure = Session.CreateCommand();

            cmdProcedure.CommandText = "dbo.dt_getpropertiesbyid";
            cmdProcedure.CommandType = CommandType.StoredProcedure;
            cmdProcedure.Parameters.AddWithValue("@id", DbConverter.FromIntNull(id));
            cmdProcedure.Parameters.AddWithValue("@property", DbConverter.FromStringNull(property));

            cmdProcedure.ExecuteNonQuery();
        }

        public static void Dt_setpropertybyid_u(DbNullable<int> id, DbNullable<string> property, DbNullable<string> uvalue, DbNullable<byte[]> lvalue)
        {
            SqlCommand cmdProcedure = Session.CreateCommand();

            cmdProcedure.CommandText = "dbo.dt_setpropertybyid_u";
            cmdProcedure.CommandType = CommandType.StoredProcedure;
            cmdProcedure.Parameters.AddWithValue("@id", DbConverter.FromIntNull(id));
            cmdProcedure.Parameters.AddWithValue("@property", DbConverter.FromStringNull(property));
            cmdProcedure.Parameters.AddWithValue("@uvalue", DbConverter.FromStringNull(uvalue));
            cmdProcedure.Parameters.AddWithValue("@lvalue", DbConverter.FromArrayNull(lvalue));

            cmdProcedure.ExecuteNonQuery();
        }

        public static void Dt_getobjwithprop_u(DbNullable<string> property, DbNullable<string> uvalue)
        {
            SqlCommand cmdProcedure = Session.CreateCommand();

            cmdProcedure.CommandText = "dbo.dt_getobjwithprop_u";
            cmdProcedure.CommandType = CommandType.StoredProcedure;
            cmdProcedure.Parameters.AddWithValue("@property", DbConverter.FromStringNull(property));
            cmdProcedure.Parameters.AddWithValue("@uvalue", DbConverter.FromStringNull(uvalue));

            cmdProcedure.ExecuteNonQuery();
        }
    }
}
