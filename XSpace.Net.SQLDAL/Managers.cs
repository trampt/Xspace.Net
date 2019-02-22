/**  版本信息模板在安装目录下，可自行修改。
* Managers.cs
*
* 功 能： N/A
* 类 名： Managers
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2019/2/14 星期四 下午 7:42:27   N/A    初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：动软卓越（北京）科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using XSpace.Net.IDAL;
using XSpace.Net.Utils;//Please add references
namespace XSpace.Net.SQLDAL
{
	/// <summary>
	/// 数据访问类:Managers
	/// </summary>
	public partial class Managers:IManagers
	{
		public Managers()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("id", "Managers"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Managers");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
			parameters[0].Value = id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}

        public bool Exists(string name,string password)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from Managers");
            strSql.Append(" where user_name=@user_name and password=@password");
            SqlParameter[] parameters = {
					new SqlParameter("@user_name", SqlDbType.NVarChar,100),
                    new SqlParameter("@password", SqlDbType.NVarChar,100)
			};
            parameters[0].Value = name;
            parameters[1].Value = password;
            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }
        public bool Exists(string name, int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from Managers");
            strSql.Append(" where user_name=@user_name and id<>@id");
            SqlParameter[] parameters = {
					new SqlParameter("@user_name", SqlDbType.NVarChar,100),
                    new SqlParameter("@id", SqlDbType.Int)
			};
            parameters[0].Value = name;
            parameters[1].Value = id;
            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }
        public bool Exists(string name)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from Managers");
            strSql.Append(" where user_name=@user_name");
            SqlParameter[] parameters = {
					new SqlParameter("@user_name", SqlDbType.NVarChar,100)
                   
			};
            parameters[0].Value = name;
            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(XSpace.Net.Model.Managers model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Managers(");
			strSql.Append("role_id,role_type,user_name,password,salt,avatar,real_name,telephone,email,is_audit,is_lock,add_time)");
			strSql.Append(" values (");
			strSql.Append("@role_id,@role_type,@user_name,@password,@salt,@avatar,@real_name,@telephone,@email,@is_audit,@is_lock,@add_time)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@role_id", SqlDbType.Int,4),
					new SqlParameter("@role_type", SqlDbType.Int,4),
					new SqlParameter("@user_name", SqlDbType.NVarChar,100),
					new SqlParameter("@password", SqlDbType.NVarChar,100),
					new SqlParameter("@salt", SqlDbType.NVarChar,20),
					new SqlParameter("@avatar", SqlDbType.NVarChar,255),
					new SqlParameter("@real_name", SqlDbType.NVarChar,50),
					new SqlParameter("@telephone", SqlDbType.NVarChar,30),
					new SqlParameter("@email", SqlDbType.NVarChar,30),
					new SqlParameter("@is_audit", SqlDbType.TinyInt,1),
					new SqlParameter("@is_lock", SqlDbType.Int,4),
					new SqlParameter("@add_time", SqlDbType.DateTime)};
			parameters[0].Value = model.role_id;
			parameters[1].Value = model.role_type;
			parameters[2].Value = model.user_name;
			parameters[3].Value = model.password;
			parameters[4].Value = model.salt;
			parameters[5].Value = model.avatar;
			parameters[6].Value = model.real_name;
			parameters[7].Value = model.telephone;
			parameters[8].Value = model.email;
			parameters[9].Value = model.is_audit;
			parameters[10].Value = model.is_lock;
			parameters[11].Value = model.add_time;

			object obj = DbHelperSQL.GetSingle(strSql.ToString(),parameters);
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(XSpace.Net.Model.Managers model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Managers set ");
			strSql.Append("role_id=@role_id,");
			strSql.Append("role_type=@role_type,");
			strSql.Append("user_name=@user_name,");
			strSql.Append("password=@password,");
			strSql.Append("salt=@salt,");
			strSql.Append("avatar=@avatar,");
			strSql.Append("real_name=@real_name,");
			strSql.Append("telephone=@telephone,");
			strSql.Append("email=@email,");
			strSql.Append("is_audit=@is_audit,");
			strSql.Append("is_lock=@is_lock,");
			strSql.Append("add_time=@add_time");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@role_id", SqlDbType.Int,4),
					new SqlParameter("@role_type", SqlDbType.Int,4),
					new SqlParameter("@user_name", SqlDbType.NVarChar,100),
					new SqlParameter("@password", SqlDbType.NVarChar,100),
					new SqlParameter("@salt", SqlDbType.NVarChar,20),
					new SqlParameter("@avatar", SqlDbType.NVarChar,255),
					new SqlParameter("@real_name", SqlDbType.NVarChar,50),
					new SqlParameter("@telephone", SqlDbType.NVarChar,30),
					new SqlParameter("@email", SqlDbType.NVarChar,30),
					new SqlParameter("@is_audit", SqlDbType.TinyInt,1),
					new SqlParameter("@is_lock", SqlDbType.Int,4),
					new SqlParameter("@add_time", SqlDbType.DateTime),
					new SqlParameter("@id", SqlDbType.Int,4)};
			parameters[0].Value = model.role_id;
			parameters[1].Value = model.role_type;
			parameters[2].Value = model.user_name;
			parameters[3].Value = model.password;
			parameters[4].Value = model.salt;
			parameters[5].Value = model.avatar;
			parameters[6].Value = model.real_name;
			parameters[7].Value = model.telephone;
			parameters[8].Value = model.email;
			parameters[9].Value = model.is_audit;
			parameters[10].Value = model.is_lock;
			parameters[11].Value = model.add_time;
			parameters[12].Value = model.id;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Managers ");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
			parameters[0].Value = id;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Managers ");
			strSql.Append(" where id in ("+idlist + ")  ");
			int rows=DbHelperSQL.ExecuteSql(strSql.ToString());
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public XSpace.Net.Model.Managers GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 id,role_id,role_type,user_name,password,salt,avatar,real_name,telephone,email,is_audit,is_lock,add_time from Managers ");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
			parameters[0].Value = id;

			XSpace.Net.Model.Managers model=new XSpace.Net.Model.Managers();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				return DataRowToModel(ds.Tables[0].Rows[0]);
			}
			else
			{
				return null;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public XSpace.Net.Model.Managers DataRowToModel(DataRow row)
		{
			XSpace.Net.Model.Managers model=new XSpace.Net.Model.Managers();
			if (row != null)
			{
				if(row["id"]!=null && row["id"].ToString()!="")
				{
					model.id=int.Parse(row["id"].ToString());
				}
				if(row["role_id"]!=null && row["role_id"].ToString()!="")
				{
					model.role_id=int.Parse(row["role_id"].ToString());
				}
				if(row["role_type"]!=null && row["role_type"].ToString()!="")
				{
					model.role_type=int.Parse(row["role_type"].ToString());
				}
				if(row["user_name"]!=null)
				{
					model.user_name=row["user_name"].ToString();
				}
				if(row["password"]!=null)
				{
					model.password=row["password"].ToString();
				}
				if(row["salt"]!=null)
				{
					model.salt=row["salt"].ToString();
				}
				if(row["avatar"]!=null)
				{
					model.avatar=row["avatar"].ToString();
				}
				if(row["real_name"]!=null)
				{
					model.real_name=row["real_name"].ToString();
				}
				if(row["telephone"]!=null)
				{
					model.telephone=row["telephone"].ToString();
				}
				if(row["email"]!=null)
				{
					model.email=row["email"].ToString();
				}
				if(row["is_audit"]!=null && row["is_audit"].ToString()!="")
				{
					model.is_audit=int.Parse(row["is_audit"].ToString());
				}
				if(row["is_lock"]!=null && row["is_lock"].ToString()!="")
				{
					model.is_lock=int.Parse(row["is_lock"].ToString());
				}
				if(row["add_time"]!=null && row["add_time"].ToString()!="")
				{
					model.add_time=DateTime.Parse(row["add_time"].ToString());
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select id,role_id,role_type,user_name,password,salt,avatar,real_name,telephone,email,is_audit,is_lock,add_time ");
			strSql.Append(" FROM Managers ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" id,role_id,role_type,user_name,password,salt,avatar,real_name,telephone,email,is_audit,is_lock,add_time ");
			strSql.Append(" FROM Managers ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM Managers ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = DbHelperSQL.GetSingle(strSql.ToString());
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.id desc");
			}
			strSql.Append(")AS Row, T.*  from Managers T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			SqlParameter[] parameters = {
					new SqlParameter("@tblName", SqlDbType.VarChar, 255),
					new SqlParameter("@fldName", SqlDbType.VarChar, 255),
					new SqlParameter("@PageSize", SqlDbType.Int),
					new SqlParameter("@PageIndex", SqlDbType.Int),
					new SqlParameter("@IsReCount", SqlDbType.Bit),
					new SqlParameter("@OrderType", SqlDbType.Bit),
					new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
					};
			parameters[0].Value = "Managers";
			parameters[1].Value = "id";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

