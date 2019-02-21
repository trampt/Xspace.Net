/**  版本信息模板在安装目录下，可自行修改。
* Orders.cs
*
* 功 能： N/A
* 类 名： Orders
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
namespace XSpace.Net.Model
{
	/// <summary>
	/// Orders:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Orders
	{
		public Orders()
		{}
		#region Model
		private int _id;
		private int? _resource_id;
		private string _order_no;
		private string _trade_no;
		private int? _user_id;
		private string _user_name;
		private int? _payment_id;
		private decimal? _payment_fee;
		private int? _payment_status;
		private DateTime? _payment_time;
		private string _telphone;
		private string _mobile;
		private string _email;
		private string _area;
		private string _address;
		private string _message;
		private string _remark;
		private decimal? _payable_amount;
		private decimal? _real_amount;
		private decimal? _order_amount;
		private int? _point;
		private int? _status;
		private DateTime? _add_time;
		private DateTime? _confirm_time;
		private DateTime? _complete_time;
		/// <summary>
		/// 
		/// </summary>
		public int id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? resource_id
		{
			set{ _resource_id=value;}
			get{return _resource_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string order_no
		{
			set{ _order_no=value;}
			get{return _order_no;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string trade_no
		{
			set{ _trade_no=value;}
			get{return _trade_no;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? user_id
		{
			set{ _user_id=value;}
			get{return _user_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string user_name
		{
			set{ _user_name=value;}
			get{return _user_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? payment_id
		{
			set{ _payment_id=value;}
			get{return _payment_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? payment_fee
		{
			set{ _payment_fee=value;}
			get{return _payment_fee;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? payment_status
		{
			set{ _payment_status=value;}
			get{return _payment_status;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? payment_time
		{
			set{ _payment_time=value;}
			get{return _payment_time;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string telphone
		{
			set{ _telphone=value;}
			get{return _telphone;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string mobile
		{
			set{ _mobile=value;}
			get{return _mobile;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string email
		{
			set{ _email=value;}
			get{return _email;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string area
		{
			set{ _area=value;}
			get{return _area;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string address
		{
			set{ _address=value;}
			get{return _address;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string message
		{
			set{ _message=value;}
			get{return _message;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string remark
		{
			set{ _remark=value;}
			get{return _remark;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? payable_amount
		{
			set{ _payable_amount=value;}
			get{return _payable_amount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? real_amount
		{
			set{ _real_amount=value;}
			get{return _real_amount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? order_amount
		{
			set{ _order_amount=value;}
			get{return _order_amount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? point
		{
			set{ _point=value;}
			get{return _point;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? status
		{
			set{ _status=value;}
			get{return _status;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? add_time
		{
			set{ _add_time=value;}
			get{return _add_time;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? confirm_time
		{
			set{ _confirm_time=value;}
			get{return _confirm_time;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? complete_time
		{
			set{ _complete_time=value;}
			get{return _complete_time;}
		}
		#endregion Model

	}
}

