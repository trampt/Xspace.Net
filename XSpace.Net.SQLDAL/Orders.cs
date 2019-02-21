/**  版本信息模板在安装目录下，可自行修改。
* Orders.cs
*
* 功 能： N/A
* 类 名： Orders
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
	/// 数据访问类:Orders
	/// </summary>
	public partial class Orders:IOrders
	{
		public Orders()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("id", "Orders"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Orders");
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
		public int Add(XSpace.Net.Model.Orders model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Orders(");
			strSql.Append("resource_id,order_no,trade_no,user_id,user_name,payment_id,payment_fee,payment_status,payment_time,telphone,mobile,email,area,address,message,remark,payable_amount,real_amount,order_amount,point,status,add_time,confirm_time,complete_time)");
			strSql.Append(" values (");
			strSql.Append("@resource_id,@order_no,@trade_no,@user_id,@user_name,@payment_id,@payment_fee,@payment_status,@payment_time,@telphone,@mobile,@email,@area,@address,@message,@remark,@payable_amount,@real_amount,@order_amount,@point,@status,@add_time,@confirm_time,@complete_time)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@resource_id", SqlDbType.Int,4),
					new SqlParameter("@order_no", SqlDbType.NVarChar,100),
					new SqlParameter("@trade_no", SqlDbType.NVarChar,100),
					new SqlParameter("@user_id", SqlDbType.Int,4),
					new SqlParameter("@user_name", SqlDbType.NVarChar,100),
					new SqlParameter("@payment_id", SqlDbType.Int,4),
					new SqlParameter("@payment_fee", SqlDbType.Decimal,5),
					new SqlParameter("@payment_status", SqlDbType.TinyInt,1),
					new SqlParameter("@payment_time", SqlDbType.DateTime),
					new SqlParameter("@telphone", SqlDbType.NVarChar,30),
					new SqlParameter("@mobile", SqlDbType.NVarChar,20),
					new SqlParameter("@email", SqlDbType.NVarChar,30),
					new SqlParameter("@area", SqlDbType.NVarChar,100),
					new SqlParameter("@address", SqlDbType.NVarChar,500),
					new SqlParameter("@message", SqlDbType.NVarChar,500),
					new SqlParameter("@remark", SqlDbType.NVarChar,500),
					new SqlParameter("@payable_amount", SqlDbType.Decimal,5),
					new SqlParameter("@real_amount", SqlDbType.Decimal,5),
					new SqlParameter("@order_amount", SqlDbType.Decimal,5),
					new SqlParameter("@point", SqlDbType.Int,4),
					new SqlParameter("@status", SqlDbType.TinyInt,1),
					new SqlParameter("@add_time", SqlDbType.DateTime),
					new SqlParameter("@confirm_time", SqlDbType.DateTime),
					new SqlParameter("@complete_time", SqlDbType.DateTime)};
			parameters[0].Value = model.resource_id;
			parameters[1].Value = model.order_no;
			parameters[2].Value = model.trade_no;
			parameters[3].Value = model.user_id;
			parameters[4].Value = model.user_name;
			parameters[5].Value = model.payment_id;
			parameters[6].Value = model.payment_fee;
			parameters[7].Value = model.payment_status;
			parameters[8].Value = model.payment_time;
			parameters[9].Value = model.telphone;
			parameters[10].Value = model.mobile;
			parameters[11].Value = model.email;
			parameters[12].Value = model.area;
			parameters[13].Value = model.address;
			parameters[14].Value = model.message;
			parameters[15].Value = model.remark;
			parameters[16].Value = model.payable_amount;
			parameters[17].Value = model.real_amount;
			parameters[18].Value = model.order_amount;
			parameters[19].Value = model.point;
			parameters[20].Value = model.status;
			parameters[21].Value = model.add_time;
			parameters[22].Value = model.confirm_time;
			parameters[23].Value = model.complete_time;

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
		public bool Update(XSpace.Net.Model.Orders model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Orders set ");
			strSql.Append("resource_id=@resource_id,");
			strSql.Append("order_no=@order_no,");
			strSql.Append("trade_no=@trade_no,");
			strSql.Append("user_id=@user_id,");
			strSql.Append("user_name=@user_name,");
			strSql.Append("payment_id=@payment_id,");
			strSql.Append("payment_fee=@payment_fee,");
			strSql.Append("payment_status=@payment_status,");
			strSql.Append("payment_time=@payment_time,");
			strSql.Append("telphone=@telphone,");
			strSql.Append("mobile=@mobile,");
			strSql.Append("email=@email,");
			strSql.Append("area=@area,");
			strSql.Append("address=@address,");
			strSql.Append("message=@message,");
			strSql.Append("remark=@remark,");
			strSql.Append("payable_amount=@payable_amount,");
			strSql.Append("real_amount=@real_amount,");
			strSql.Append("order_amount=@order_amount,");
			strSql.Append("point=@point,");
			strSql.Append("status=@status,");
			strSql.Append("add_time=@add_time,");
			strSql.Append("confirm_time=@confirm_time,");
			strSql.Append("complete_time=@complete_time");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@resource_id", SqlDbType.Int,4),
					new SqlParameter("@order_no", SqlDbType.NVarChar,100),
					new SqlParameter("@trade_no", SqlDbType.NVarChar,100),
					new SqlParameter("@user_id", SqlDbType.Int,4),
					new SqlParameter("@user_name", SqlDbType.NVarChar,100),
					new SqlParameter("@payment_id", SqlDbType.Int,4),
					new SqlParameter("@payment_fee", SqlDbType.Decimal,5),
					new SqlParameter("@payment_status", SqlDbType.TinyInt,1),
					new SqlParameter("@payment_time", SqlDbType.DateTime),
					new SqlParameter("@telphone", SqlDbType.NVarChar,30),
					new SqlParameter("@mobile", SqlDbType.NVarChar,20),
					new SqlParameter("@email", SqlDbType.NVarChar,30),
					new SqlParameter("@area", SqlDbType.NVarChar,100),
					new SqlParameter("@address", SqlDbType.NVarChar,500),
					new SqlParameter("@message", SqlDbType.NVarChar,500),
					new SqlParameter("@remark", SqlDbType.NVarChar,500),
					new SqlParameter("@payable_amount", SqlDbType.Decimal,5),
					new SqlParameter("@real_amount", SqlDbType.Decimal,5),
					new SqlParameter("@order_amount", SqlDbType.Decimal,5),
					new SqlParameter("@point", SqlDbType.Int,4),
					new SqlParameter("@status", SqlDbType.TinyInt,1),
					new SqlParameter("@add_time", SqlDbType.DateTime),
					new SqlParameter("@confirm_time", SqlDbType.DateTime),
					new SqlParameter("@complete_time", SqlDbType.DateTime),
					new SqlParameter("@id", SqlDbType.Int,4)};
			parameters[0].Value = model.resource_id;
			parameters[1].Value = model.order_no;
			parameters[2].Value = model.trade_no;
			parameters[3].Value = model.user_id;
			parameters[4].Value = model.user_name;
			parameters[5].Value = model.payment_id;
			parameters[6].Value = model.payment_fee;
			parameters[7].Value = model.payment_status;
			parameters[8].Value = model.payment_time;
			parameters[9].Value = model.telphone;
			parameters[10].Value = model.mobile;
			parameters[11].Value = model.email;
			parameters[12].Value = model.area;
			parameters[13].Value = model.address;
			parameters[14].Value = model.message;
			parameters[15].Value = model.remark;
			parameters[16].Value = model.payable_amount;
			parameters[17].Value = model.real_amount;
			parameters[18].Value = model.order_amount;
			parameters[19].Value = model.point;
			parameters[20].Value = model.status;
			parameters[21].Value = model.add_time;
			parameters[22].Value = model.confirm_time;
			parameters[23].Value = model.complete_time;
			parameters[24].Value = model.id;

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
			strSql.Append("delete from Orders ");
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
			strSql.Append("delete from Orders ");
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
		public XSpace.Net.Model.Orders GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 id,resource_id,order_no,trade_no,user_id,user_name,payment_id,payment_fee,payment_status,payment_time,telphone,mobile,email,area,address,message,remark,payable_amount,real_amount,order_amount,point,status,add_time,confirm_time,complete_time from Orders ");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
			parameters[0].Value = id;

			XSpace.Net.Model.Orders model=new XSpace.Net.Model.Orders();
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
		public XSpace.Net.Model.Orders DataRowToModel(DataRow row)
		{
			XSpace.Net.Model.Orders model=new XSpace.Net.Model.Orders();
			if (row != null)
			{
				if(row["id"]!=null && row["id"].ToString()!="")
				{
					model.id=int.Parse(row["id"].ToString());
				}
				if(row["resource_id"]!=null && row["resource_id"].ToString()!="")
				{
					model.resource_id=int.Parse(row["resource_id"].ToString());
				}
				if(row["order_no"]!=null)
				{
					model.order_no=row["order_no"].ToString();
				}
				if(row["trade_no"]!=null)
				{
					model.trade_no=row["trade_no"].ToString();
				}
				if(row["user_id"]!=null && row["user_id"].ToString()!="")
				{
					model.user_id=int.Parse(row["user_id"].ToString());
				}
				if(row["user_name"]!=null)
				{
					model.user_name=row["user_name"].ToString();
				}
				if(row["payment_id"]!=null && row["payment_id"].ToString()!="")
				{
					model.payment_id=int.Parse(row["payment_id"].ToString());
				}
				if(row["payment_fee"]!=null && row["payment_fee"].ToString()!="")
				{
					model.payment_fee=decimal.Parse(row["payment_fee"].ToString());
				}
				if(row["payment_status"]!=null && row["payment_status"].ToString()!="")
				{
					model.payment_status=int.Parse(row["payment_status"].ToString());
				}
				if(row["payment_time"]!=null && row["payment_time"].ToString()!="")
				{
					model.payment_time=DateTime.Parse(row["payment_time"].ToString());
				}
				if(row["telphone"]!=null)
				{
					model.telphone=row["telphone"].ToString();
				}
				if(row["mobile"]!=null)
				{
					model.mobile=row["mobile"].ToString();
				}
				if(row["email"]!=null)
				{
					model.email=row["email"].ToString();
				}
				if(row["area"]!=null)
				{
					model.area=row["area"].ToString();
				}
				if(row["address"]!=null)
				{
					model.address=row["address"].ToString();
				}
				if(row["message"]!=null)
				{
					model.message=row["message"].ToString();
				}
				if(row["remark"]!=null)
				{
					model.remark=row["remark"].ToString();
				}
				if(row["payable_amount"]!=null && row["payable_amount"].ToString()!="")
				{
					model.payable_amount=decimal.Parse(row["payable_amount"].ToString());
				}
				if(row["real_amount"]!=null && row["real_amount"].ToString()!="")
				{
					model.real_amount=decimal.Parse(row["real_amount"].ToString());
				}
				if(row["order_amount"]!=null && row["order_amount"].ToString()!="")
				{
					model.order_amount=decimal.Parse(row["order_amount"].ToString());
				}
				if(row["point"]!=null && row["point"].ToString()!="")
				{
					model.point=int.Parse(row["point"].ToString());
				}
				if(row["status"]!=null && row["status"].ToString()!="")
				{
					model.status=int.Parse(row["status"].ToString());
				}
				if(row["add_time"]!=null && row["add_time"].ToString()!="")
				{
					model.add_time=DateTime.Parse(row["add_time"].ToString());
				}
				if(row["confirm_time"]!=null && row["confirm_time"].ToString()!="")
				{
					model.confirm_time=DateTime.Parse(row["confirm_time"].ToString());
				}
				if(row["complete_time"]!=null && row["complete_time"].ToString()!="")
				{
					model.complete_time=DateTime.Parse(row["complete_time"].ToString());
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
			strSql.Append("select id,resource_id,order_no,trade_no,user_id,user_name,payment_id,payment_fee,payment_status,payment_time,telphone,mobile,email,area,address,message,remark,payable_amount,real_amount,order_amount,point,status,add_time,confirm_time,complete_time ");
			strSql.Append(" FROM Orders ");
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
			strSql.Append(" id,resource_id,order_no,trade_no,user_id,user_name,payment_id,payment_fee,payment_status,payment_time,telphone,mobile,email,area,address,message,remark,payable_amount,real_amount,order_amount,point,status,add_time,confirm_time,complete_time ");
			strSql.Append(" FROM Orders ");
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
			strSql.Append("select count(1) FROM Orders ");
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
			strSql.Append(")AS Row, T.*  from Orders T ");
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
			parameters[0].Value = "Orders";
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

