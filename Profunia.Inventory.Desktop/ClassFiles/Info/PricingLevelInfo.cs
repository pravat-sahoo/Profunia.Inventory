using System;

namespace Profunia.Inventory.Desktop.ClassFiles.Info
{
	internal class PricingLevelInfo
	{
		private decimal _pricinglevelId;

		private string _pricinglevelName;

		private string _narration;

		private DateTime _extraDate;

		private string _extra1;

		private string _extra2;

		public decimal PricinglevelId
		{
			get
			{
				return _pricinglevelId;
			}
			set
			{
				_pricinglevelId = value;
			}
		}

		public string PricinglevelName
		{
			get
			{
				return _pricinglevelName;
			}
			set
			{
				_pricinglevelName = value;
			}
		}

		public string Narration
		{
			get
			{
				return _narration;
			}
			set
			{
				_narration = value;
			}
		}

		public DateTime ExtraDate
		{
			get
			{
				return _extraDate;
			}
			set
			{
				_extraDate = value;
			}
		}

		public string Extra1
		{
			get
			{
				return _extra1;
			}
			set
			{
				_extra1 = value;
			}
		}

		public string Extra2
		{
			get
			{
				return _extra2;
			}
			set
			{
				_extra2 = value;
			}
		}
	}
}
