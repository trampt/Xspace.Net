/**  版本信息模板在安装目录下，可自行修改。
* Channels.cs
*
* 功 能： N/A
* 类 名： Channels
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2019/2/14 星期四 下午 7:42:26   N/A    初版
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
	/// Channels:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Channels
	{
		public Channels()
		{}
		#region Model
		private int _id;
		private string _name;
		private string _title;
		private int? _is_comment;
		private int? _is_albums;
		private int? _is_attach;
		private int? _is_spec;
		private int? _is_contribute;
		private int? _sort_id;
		private int? _is_lock;
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
		public string name
		{
			set{ _name=value;}
			get{return _name;}
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
		public int? is_comment
		{
			set{ _is_comment=value;}
			get{return _is_comment;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? is_albums
		{
			set{ _is_albums=value;}
			get{return _is_albums;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? is_attach
		{
			set{ _is_attach=value;}
			get{return _is_attach;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? is_spec
		{
			set{ _is_spec=value;}
			get{return _is_spec;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? is_contribute
		{
			set{ _is_contribute=value;}
			get{return _is_contribute;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? sort_id
		{
			set{ _sort_id=value;}
			get{return _sort_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? is_lock
		{
			set{ _is_lock=value;}
			get{return _is_lock;}
		}
		#endregion Model

	}
}

