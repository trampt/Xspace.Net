﻿/**  版本信息模板在安装目录下，可自行修改。
* Resources.cs
*
* 功 能： N/A
* 类 名： Resources
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2019/2/14 星期四 下午 7:42:28   N/A    初版
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
	/// 数据访问类:Resources
	/// </summary>
	public partial class Resources:IResources
	{
		public Resources()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("id", "Resources"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Resources");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
			parameters[0].Value = id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(XSpace.Net.Model.Resources model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Resources(");
			strSql.Append("channel_id,category_id,call_index,title,link_url,img_url,seo_title,seo_keywords,seo_description,tags,zhaiyao,content,sort_id,click,status,is_msg,is_top,is_red,is_hot,is_slide,is_sys,user_name,like_count,add_time,update_time,video_src,sub_title,Price)");
			strSql.Append(" values (");
			strSql.Append("@channel_id,@category_id,@call_index,@title,@link_url,@img_url,@seo_title,@seo_keywords,@seo_description,@tags,@zhaiyao,@content,@sort_id,@click,@status,@is_msg,@is_top,@is_red,@is_hot,@is_slide,@is_sys,@user_name,@like_count,@add_time,@update_time,@video_src,@sub_title,@Price)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@channel_id", SqlDbType.Int,4),
					new SqlParameter("@category_id", SqlDbType.Int,4),
					new SqlParameter("@call_index", SqlDbType.NVarChar,50),
					new SqlParameter("@title", SqlDbType.NVarChar,100),
					new SqlParameter("@link_url", SqlDbType.NVarChar,255),
					new SqlParameter("@img_url", SqlDbType.NVarChar,255),
					new SqlParameter("@seo_title", SqlDbType.NVarChar,255),
					new SqlParameter("@seo_keywords", SqlDbType.NVarChar,255),
					new SqlParameter("@seo_description", SqlDbType.NVarChar,255),
					new SqlParameter("@tags", SqlDbType.NVarChar,500),
					new SqlParameter("@zhaiyao", SqlDbType.NVarChar,255),
					new SqlParameter("@content", SqlDbType.NText),
					new SqlParameter("@sort_id", SqlDbType.Int,4),
					new SqlParameter("@click", SqlDbType.Int,4),
					new SqlParameter("@status", SqlDbType.Int,4),
					new SqlParameter("@is_msg", SqlDbType.Int,4),
					new SqlParameter("@is_top", SqlDbType.Int,4),
					new SqlParameter("@is_red", SqlDbType.Int,4),
					new SqlParameter("@is_hot", SqlDbType.Int,4),
					new SqlParameter("@is_slide", SqlDbType.Int,4),
					new SqlParameter("@is_sys", SqlDbType.Int,4),
					new SqlParameter("@user_name", SqlDbType.NVarChar,100),
					new SqlParameter("@like_count", SqlDbType.Int,4),
					new SqlParameter("@add_time", SqlDbType.DateTime),
					new SqlParameter("@update_time", SqlDbType.DateTime),
					new SqlParameter("@video_src", SqlDbType.NVarChar,255),
					new SqlParameter("@sub_title", SqlDbType.NVarChar,255),
					new SqlParameter("@Price", SqlDbType.Decimal,9)};
			parameters[0].Value = model.channel_id;
			parameters[1].Value = model.category_id;
			parameters[2].Value = model.call_index;
			parameters[3].Value = model.title;
			parameters[4].Value = model.link_url;
			parameters[5].Value = model.img_url;
			parameters[6].Value = model.seo_title;
			parameters[7].Value = model.seo_keywords;
			parameters[8].Value = model.seo_description;
			parameters[9].Value = model.tags;
			parameters[10].Value = model.zhaiyao;
			parameters[11].Value = model.content;
			parameters[12].Value = model.sort_id;
			parameters[13].Value = model.click;
			parameters[14].Value = model.status;
			parameters[15].Value = model.is_msg;
			parameters[16].Value = model.is_top;
			parameters[17].Value = model.is_red;
			parameters[18].Value = model.is_hot;
			parameters[19].Value = model.is_slide;
			parameters[20].Value = model.is_sys;
			parameters[21].Value = model.user_name;
			parameters[22].Value = model.like_count;
			parameters[23].Value = model.add_time;
			parameters[24].Value = model.update_time;
			parameters[25].Value = model.video_src;
			parameters[26].Value = model.sub_title;
			parameters[27].Value = model.Price;

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
		public bool Update(XSpace.Net.Model.Resources model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Resources set ");
			strSql.Append("channel_id=@channel_id,");
			strSql.Append("category_id=@category_id,");
			strSql.Append("call_index=@call_index,");
			strSql.Append("title=@title,");
			strSql.Append("link_url=@link_url,");
			strSql.Append("img_url=@img_url,");
			strSql.Append("seo_title=@seo_title,");
			strSql.Append("seo_keywords=@seo_keywords,");
			strSql.Append("seo_description=@seo_description,");
			strSql.Append("tags=@tags,");
			strSql.Append("zhaiyao=@zhaiyao,");
			strSql.Append("content=@content,");
			strSql.Append("sort_id=@sort_id,");
			strSql.Append("click=@click,");
			strSql.Append("status=@status,");
			strSql.Append("is_msg=@is_msg,");
			strSql.Append("is_top=@is_top,");
			strSql.Append("is_red=@is_red,");
			strSql.Append("is_hot=@is_hot,");
			strSql.Append("is_slide=@is_slide,");
			strSql.Append("is_sys=@is_sys,");
			strSql.Append("user_name=@user_name,");
			strSql.Append("like_count=@like_count,");
			strSql.Append("add_time=@add_time,");
			strSql.Append("update_time=@update_time,");
			strSql.Append("video_src=@video_src,");
			strSql.Append("sub_title=@sub_title,");
			strSql.Append("Price=@Price");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@channel_id", SqlDbType.Int,4),
					new SqlParameter("@category_id", SqlDbType.Int,4),
					new SqlParameter("@call_index", SqlDbType.NVarChar,50),
					new SqlParameter("@title", SqlDbType.NVarChar,100),
					new SqlParameter("@link_url", SqlDbType.NVarChar,255),
					new SqlParameter("@img_url", SqlDbType.NVarChar,255),
					new SqlParameter("@seo_title", SqlDbType.NVarChar,255),
					new SqlParameter("@seo_keywords", SqlDbType.NVarChar,255),
					new SqlParameter("@seo_description", SqlDbType.NVarChar,255),
					new SqlParameter("@tags", SqlDbType.NVarChar,500),
					new SqlParameter("@zhaiyao", SqlDbType.NVarChar,255),
					new SqlParameter("@content", SqlDbType.NText),
					new SqlParameter("@sort_id", SqlDbType.Int,4),
					new SqlParameter("@click", SqlDbType.Int,4),
					new SqlParameter("@status", SqlDbType.Int,4),
					new SqlParameter("@is_msg", SqlDbType.Int,4),
					new SqlParameter("@is_top", SqlDbType.Int,4),
					new SqlParameter("@is_red", SqlDbType.Int,4),
					new SqlParameter("@is_hot", SqlDbType.Int,4),
					new SqlParameter("@is_slide", SqlDbType.Int,4),
					new SqlParameter("@is_sys", SqlDbType.Int,4),
					new SqlParameter("@user_name", SqlDbType.NVarChar,100),
					new SqlParameter("@like_count", SqlDbType.Int,4),
					new SqlParameter("@add_time", SqlDbType.DateTime),
					new SqlParameter("@update_time", SqlDbType.DateTime),
					new SqlParameter("@video_src", SqlDbType.NVarChar,255),
					new SqlParameter("@sub_title", SqlDbType.NVarChar,255),
					new SqlParameter("@Price", SqlDbType.Decimal,9),
					new SqlParameter("@id", SqlDbType.Int,4)};
			parameters[0].Value = model.channel_id;
			parameters[1].Value = model.category_id;
			parameters[2].Value = model.call_index;
			parameters[3].Value = model.title;
			parameters[4].Value = model.link_url;
			parameters[5].Value = model.img_url;
			parameters[6].Value = model.seo_title;
			parameters[7].Value = model.seo_keywords;
			parameters[8].Value = model.seo_description;
			parameters[9].Value = model.tags;
			parameters[10].Value = model.zhaiyao;
			parameters[11].Value = model.content;
			parameters[12].Value = model.sort_id;
			parameters[13].Value = model.click;
			parameters[14].Value = model.status;
			parameters[15].Value = model.is_msg;
			parameters[16].Value = model.is_top;
			parameters[17].Value = model.is_red;
			parameters[18].Value = model.is_hot;
			parameters[19].Value = model.is_slide;
			parameters[20].Value = model.is_sys;
			parameters[21].Value = model.user_name;
			parameters[22].Value = model.like_count;
			parameters[23].Value = model.add_time;
			parameters[24].Value = model.update_time;
			parameters[25].Value = model.video_src;
			parameters[26].Value = model.sub_title;
			parameters[27].Value = model.Price;
			parameters[28].Value = model.id;

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
			strSql.Append("delete from Resources ");
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
			strSql.Append("delete from Resources ");
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
		public XSpace.Net.Model.Resources GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 id,channel_id,category_id,call_index,title,link_url,img_url,seo_title,seo_keywords,seo_description,tags,zhaiyao,content,sort_id,click,status,is_msg,is_top,is_red,is_hot,is_slide,is_sys,user_name,like_count,add_time,update_time,video_src,sub_title,Price from Resources ");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
			parameters[0].Value = id;

			XSpace.Net.Model.Resources model=new XSpace.Net.Model.Resources();
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
		public XSpace.Net.Model.Resources DataRowToModel(DataRow row)
		{
			XSpace.Net.Model.Resources model=new XSpace.Net.Model.Resources();
			if (row != null)
			{
				if(row["id"]!=null && row["id"].ToString()!="")
				{
					model.id=int.Parse(row["id"].ToString());
				}
				if(row["channel_id"]!=null && row["channel_id"].ToString()!="")
				{
					model.channel_id=int.Parse(row["channel_id"].ToString());
				}
				if(row["category_id"]!=null && row["category_id"].ToString()!="")
				{
					model.category_id=int.Parse(row["category_id"].ToString());
				}
				if(row["call_index"]!=null)
				{
					model.call_index=row["call_index"].ToString();
				}
				if(row["title"]!=null)
				{
					model.title=row["title"].ToString();
				}
				if(row["link_url"]!=null)
				{
					model.link_url=row["link_url"].ToString();
				}
				if(row["img_url"]!=null)
				{
					model.img_url=row["img_url"].ToString();
				}
				if(row["seo_title"]!=null)
				{
					model.seo_title=row["seo_title"].ToString();
				}
				if(row["seo_keywords"]!=null)
				{
					model.seo_keywords=row["seo_keywords"].ToString();
				}
				if(row["seo_description"]!=null)
				{
					model.seo_description=row["seo_description"].ToString();
				}
				if(row["tags"]!=null)
				{
					model.tags=row["tags"].ToString();
				}
				if(row["zhaiyao"]!=null)
				{
					model.zhaiyao=row["zhaiyao"].ToString();
				}
				if(row["content"]!=null)
				{
					model.content=row["content"].ToString();
				}
				if(row["sort_id"]!=null && row["sort_id"].ToString()!="")
				{
					model.sort_id=int.Parse(row["sort_id"].ToString());
				}
				if(row["click"]!=null && row["click"].ToString()!="")
				{
					model.click=int.Parse(row["click"].ToString());
				}
				if(row["status"]!=null && row["status"].ToString()!="")
				{
					model.status=int.Parse(row["status"].ToString());
				}
				if(row["is_msg"]!=null && row["is_msg"].ToString()!="")
				{
					model.is_msg=int.Parse(row["is_msg"].ToString());
				}
				if(row["is_top"]!=null && row["is_top"].ToString()!="")
				{
					model.is_top=int.Parse(row["is_top"].ToString());
				}
				if(row["is_red"]!=null && row["is_red"].ToString()!="")
				{
					model.is_red=int.Parse(row["is_red"].ToString());
				}
				if(row["is_hot"]!=null && row["is_hot"].ToString()!="")
				{
					model.is_hot=int.Parse(row["is_hot"].ToString());
				}
				if(row["is_slide"]!=null && row["is_slide"].ToString()!="")
				{
					model.is_slide=int.Parse(row["is_slide"].ToString());
				}
				if(row["is_sys"]!=null && row["is_sys"].ToString()!="")
				{
					model.is_sys=int.Parse(row["is_sys"].ToString());
				}
				if(row["user_name"]!=null)
				{
					model.user_name=row["user_name"].ToString();
				}
				if(row["like_count"]!=null && row["like_count"].ToString()!="")
				{
					model.like_count=int.Parse(row["like_count"].ToString());
				}
				if(row["add_time"]!=null && row["add_time"].ToString()!="")
				{
					model.add_time=DateTime.Parse(row["add_time"].ToString());
				}
				if(row["update_time"]!=null && row["update_time"].ToString()!="")
				{
					model.update_time=DateTime.Parse(row["update_time"].ToString());
				}
				if(row["video_src"]!=null)
				{
					model.video_src=row["video_src"].ToString();
				}
				if(row["sub_title"]!=null)
				{
					model.sub_title=row["sub_title"].ToString();
				}
				if(row["Price"]!=null && row["Price"].ToString()!="")
				{
					model.Price=decimal.Parse(row["Price"].ToString());
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
			strSql.Append("select id,channel_id,category_id,call_index,title,link_url,img_url,seo_title,seo_keywords,seo_description,tags,zhaiyao,content,sort_id,click,status,is_msg,is_top,is_red,is_hot,is_slide,is_sys,user_name,like_count,add_time,update_time,video_src,sub_title,Price ");
			strSql.Append(" FROM Resources ");
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
			strSql.Append(" id,channel_id,category_id,call_index,title,link_url,img_url,seo_title,seo_keywords,seo_description,tags,zhaiyao,content,sort_id,click,status,is_msg,is_top,is_red,is_hot,is_slide,is_sys,user_name,like_count,add_time,update_time,video_src,sub_title,Price ");
			strSql.Append(" FROM Resources ");
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
			strSql.Append("select count(1) FROM Resources ");
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
			strSql.Append(")AS Row, T.*  from Resources T ");
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
			parameters[0].Value = "Resources";
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

