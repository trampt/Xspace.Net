/**  版本信息模板在安装目录下，可自行修改。
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
namespace XSpace.Net.Model
{
	/// <summary>
	/// Resources:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Resources
	{
		public Resources()
		{}
		#region Model
		private int _id;
		private int _channel_id;
		private int _category_id;
		private string _call_index;
		private string _title;
		private string _link_url;
		private string _img_url;
		private string _seo_title;
		private string _seo_keywords;
		private string _seo_description;
		private string _tags;
		private string _zhaiyao;
		private string _content;
		private int _sort_id;
		private int _click;
		private int _status;
		private int _is_msg;
		private int _is_top;
		private int _is_red;
		private int _is_hot;
		private int _is_slide;
		private int _is_sys;
		private string _user_name;
		private int _like_count;
		private DateTime _add_time;
		private DateTime? _update_time;
		private string _video_src;
		private string _sub_title;
		private decimal? _price=0M;
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
		public int channel_id
		{
			set{ _channel_id=value;}
			get{return _channel_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int category_id
		{
			set{ _category_id=value;}
			get{return _category_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string call_index
		{
			set{ _call_index=value;}
			get{return _call_index;}
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
		public string link_url
		{
			set{ _link_url=value;}
			get{return _link_url;}
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
		public string seo_title
		{
			set{ _seo_title=value;}
			get{return _seo_title;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string seo_keywords
		{
			set{ _seo_keywords=value;}
			get{return _seo_keywords;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string seo_description
		{
			set{ _seo_description=value;}
			get{return _seo_description;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tags
		{
			set{ _tags=value;}
			get{return _tags;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string zhaiyao
		{
			set{ _zhaiyao=value;}
			get{return _zhaiyao;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string content
		{
			set{ _content=value;}
			get{return _content;}
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
		public int click
		{
			set{ _click=value;}
			get{return _click;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int status
		{
			set{ _status=value;}
			get{return _status;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int is_msg
		{
			set{ _is_msg=value;}
			get{return _is_msg;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int is_top
		{
			set{ _is_top=value;}
			get{return _is_top;}
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
		public int is_hot
		{
			set{ _is_hot=value;}
			get{return _is_hot;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int is_slide
		{
			set{ _is_slide=value;}
			get{return _is_slide;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int is_sys
		{
			set{ _is_sys=value;}
			get{return _is_sys;}
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
		public int like_count
		{
			set{ _like_count=value;}
			get{return _like_count;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime add_time
		{
			set{ _add_time=value;}
			get{return _add_time;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? update_time
		{
			set{ _update_time=value;}
			get{return _update_time;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string video_src
		{
			set{ _video_src=value;}
			get{return _video_src;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string sub_title
		{
			set{ _sub_title=value;}
			get{return _sub_title;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Price
		{
			set{ _price=value;}
			get{return _price;}
		}
		#endregion Model

	}
}

