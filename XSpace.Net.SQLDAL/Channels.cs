/**  版本信息模板在安装目录下，可自行修改。
* Channels.cs
*
* 功 能： N/A
* 类 名： Channels
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
using System.Collections.Generic;
namespace XSpace.Net.SQLDAL
{
	/// <summary>
	/// 数据访问类:Channels
	/// </summary>
	public partial class Channels:IChannels
	{
		public Channels()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("id", "Channels"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Channels");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
			parameters[0].Value = id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}
        public bool Exists(string name)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from Channels");
            strSql.Append(" where name=@name");
            SqlParameter[] parameters = {
					new SqlParameter("@name", SqlDbType.VarChar,50)
			};
            parameters[0].Value = name;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }
        public bool Exists(int id,string name)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from Channels");
            strSql.Append(" where name=@name and id<>@id");
            SqlParameter[] parameters = {
					new SqlParameter("@name", SqlDbType.VarChar,50),
                    new SqlParameter("@id", SqlDbType.Int)
			};
            parameters[0].Value = name;
            parameters[1].Value = id;
            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(XSpace.Net.Model.Channels model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Channels(");
			strSql.Append("name,title,is_comment,is_albums,is_attach,is_spec,is_contribute,sort_id,is_lock)");
			strSql.Append(" values (");
			strSql.Append("@name,@title,@is_comment,@is_albums,@is_attach,@is_spec,@is_contribute,@sort_id,@is_lock)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@name", SqlDbType.VarChar,50),
					new SqlParameter("@title", SqlDbType.VarChar,100),
					new SqlParameter("@is_comment", SqlDbType.TinyInt,1),
					new SqlParameter("@is_albums", SqlDbType.TinyInt,1),
					new SqlParameter("@is_attach", SqlDbType.TinyInt,1),
					new SqlParameter("@is_spec", SqlDbType.TinyInt,1),
					new SqlParameter("@is_contribute", SqlDbType.TinyInt,1),
					new SqlParameter("@sort_id", SqlDbType.Int,4),
					new SqlParameter("@is_lock", SqlDbType.TinyInt,1)};
			parameters[0].Value = model.name;
			parameters[1].Value = model.title;
			parameters[2].Value = model.is_comment;
			parameters[3].Value = model.is_albums;
			parameters[4].Value = model.is_attach;
			parameters[5].Value = model.is_spec;
			parameters[6].Value = model.is_contribute;
			parameters[7].Value = model.sort_id;
			parameters[8].Value = model.is_lock;

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
		public bool Update(XSpace.Net.Model.Channels model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Channels set ");
			strSql.Append("name=@name,");
			strSql.Append("title=@title,");
			strSql.Append("is_comment=@is_comment,");
			strSql.Append("is_albums=@is_albums,");
			strSql.Append("is_attach=@is_attach,");
			strSql.Append("is_spec=@is_spec,");
			strSql.Append("is_contribute=@is_contribute,");
			strSql.Append("sort_id=@sort_id,");
			strSql.Append("is_lock=@is_lock");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@name", SqlDbType.VarChar,50),
					new SqlParameter("@title", SqlDbType.VarChar,100),
					new SqlParameter("@is_comment", SqlDbType.TinyInt,1),
					new SqlParameter("@is_albums", SqlDbType.TinyInt,1),
					new SqlParameter("@is_attach", SqlDbType.TinyInt,1),
					new SqlParameter("@is_spec", SqlDbType.TinyInt,1),
					new SqlParameter("@is_contribute", SqlDbType.TinyInt,1),
					new SqlParameter("@sort_id", SqlDbType.Int,4),
					new SqlParameter("@is_lock", SqlDbType.TinyInt,1),
					new SqlParameter("@id", SqlDbType.Int,4)};
			parameters[0].Value = model.name;
			parameters[1].Value = model.title;
			parameters[2].Value = model.is_comment;
			parameters[3].Value = model.is_albums;
			parameters[4].Value = model.is_attach;
			parameters[5].Value = model.is_spec;
			parameters[6].Value = model.is_contribute;
			parameters[7].Value = model.sort_id;
			parameters[8].Value = model.is_lock;
			parameters[9].Value = model.id;

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
			strSql.Append("delete from Channels ");
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
			strSql.Append("delete from Channels ");
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
		public XSpace.Net.Model.Channels GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 id,name,title,is_comment,is_albums,is_attach,is_spec,is_contribute,sort_id,is_lock from Channels ");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
			parameters[0].Value = id;

			XSpace.Net.Model.Channels model=new XSpace.Net.Model.Channels();
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
		public XSpace.Net.Model.Channels DataRowToModel(DataRow row)
		{
			XSpace.Net.Model.Channels model=new XSpace.Net.Model.Channels();
			if (row != null)
			{
				if(row["id"]!=null && row["id"].ToString()!="")
				{
					model.id=int.Parse(row["id"].ToString());
				}
				if(row["name"]!=null)
				{
					model.name=row["name"].ToString();
				}
				if(row["title"]!=null)
				{
					model.title=row["title"].ToString();
				}
				if(row["is_comment"]!=null && row["is_comment"].ToString()!="")
				{
					model.is_comment=int.Parse(row["is_comment"].ToString());
				}
				if(row["is_albums"]!=null && row["is_albums"].ToString()!="")
				{
					model.is_albums=int.Parse(row["is_albums"].ToString());
				}
				if(row["is_attach"]!=null && row["is_attach"].ToString()!="")
				{
					model.is_attach=int.Parse(row["is_attach"].ToString());
				}
				if(row["is_spec"]!=null && row["is_spec"].ToString()!="")
				{
					model.is_spec=int.Parse(row["is_spec"].ToString());
				}
				if(row["is_contribute"]!=null && row["is_contribute"].ToString()!="")
				{
					model.is_contribute=int.Parse(row["is_contribute"].ToString());
				}
				if(row["sort_id"]!=null && row["sort_id"].ToString()!="")
				{
					model.sort_id=int.Parse(row["sort_id"].ToString());
				}
				if(row["is_lock"]!=null && row["is_lock"].ToString()!="")
				{
					model.is_lock=int.Parse(row["is_lock"].ToString());
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
			strSql.Append("select id,name,title,is_comment,is_albums,is_attach,is_spec,is_contribute,sort_id,is_lock ");
			strSql.Append(" FROM Channels ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

        public List<XSpace.Net.Model.Channels> GetListModels(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id,name,title,is_comment,is_albums,is_attach,is_spec,is_contribute,sort_id,is_lock ");
            strSql.Append(" FROM Channels ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            DataSet ds = DbHelperSQL.Query(strSql.ToString());
            List<XSpace.Net.Model.Channels> models = new List<Model.Channels>();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                models.Add(DataRowToModel(dr));
            }
            return models;
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
			strSql.Append(" id,name,title,is_comment,is_albums,is_attach,is_spec,is_contribute,sort_id,is_lock ");
			strSql.Append(" FROM Channels ");
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
			strSql.Append("select count(1) FROM Channels ");
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
			strSql.Append(")AS Row, T.*  from Channels T ");
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
			parameters[0].Value = "Channels";
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

