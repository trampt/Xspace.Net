/**  版本信息模板在安装目录下，可自行修改。
* Links.cs
*
* 功 能： N/A
* 类 名： Links
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
	/// Links:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Links
	{
		public Links()
		{}
		#region Model
		private int _id;
		private string _title;
		private string _user_name;
		private string _user_tel;
		private string _email;
		private string _site_url;
		private string _img_url;
		private int _is_image;
		private int _sort_id;
		private int _is_red;
		private int _is_lock;
		private DateTime? _add_time;
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
		public string title
		{
			set{ _title=value;}
			get{return _title;}
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
		public string user_tel
		{
			set{ _user_tel=value;}
			get{return _user_tel;}
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
		public string site_url
		{
			set{ _site_url=value;}
			get{return _site_url;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string img_url
		{
			set{ _img_url=value;}
			get{return _img_url;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int is_image
		{
			set{ _is_image=value;}
			get{return _is_image;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int sort_id
		{
			set{ _sort_id=value;}
			get{return _sort_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int is_red
		{
			set{ _is_red=value;}
			get{return _is_red;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int is_lock
		{
			set{ _is_lock=value;}
			get{return _is_lock;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? add_time
		{
			set{ _add_time=value;}
			get{return _add_time;}
		}
		#endregion Model

	}
}

