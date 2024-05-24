namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: UsrRealtyEventsSchema

	/// <exclude/>
	public class UsrRealtyEventsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public UsrRealtyEventsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public UsrRealtyEventsSchema(UsrRealtyEventsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("74d49b78-e0aa-4469-9a52-40cc8d708b0d");
			Name = "UsrRealtyEvents";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("1b20f82a-6797-466b-aac8-7f8b0b6c1da4");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,82,193,110,219,48,12,189,7,200,63,16,198,14,54,16,8,237,117,217,10,52,89,54,20,40,182,161,118,122,25,122,80,100,198,213,32,75,134,36,167,203,134,254,251,40,203,94,92,167,3,202,139,44,234,241,241,61,154,154,215,232,26,46,16,10,180,150,59,179,247,108,109,244,94,86,173,229,94,26,61,159,253,153,207,128,162,117,82,87,144,31,157,199,122,57,78,141,11,235,218,232,255,62,90,100,27,237,165,151,232,222,130,97,155,3,106,63,64,127,116,233,99,151,187,149,36,66,163,77,115,241,136,53,255,74,30,224,35,36,91,103,239,144,43,127,76,178,135,249,44,150,53,237,78,73,1,66,113,231,32,190,190,66,4,239,97,197,29,190,242,18,89,250,17,140,8,205,129,68,203,18,225,96,100,9,223,116,206,15,100,37,53,187,159,40,60,56,212,37,218,5,68,194,21,238,201,87,71,123,109,43,7,152,157,232,70,204,33,118,164,130,253,99,27,104,48,91,190,132,69,94,176,157,31,178,158,198,68,22,11,38,224,18,133,172,185,130,198,74,17,230,20,171,216,23,244,197,177,193,114,109,84,91,235,123,174,90,252,208,67,175,210,48,203,239,1,191,205,63,37,211,238,114,15,105,36,187,130,203,139,33,178,151,160,137,177,16,200,110,220,154,107,129,10,75,210,225,109,139,203,225,63,141,195,121,27,214,130,22,211,241,10,11,172,27,197,125,80,174,241,9,110,141,224,74,254,230,59,133,121,135,75,123,63,91,135,150,54,87,211,252,105,109,217,29,58,211,90,65,32,99,137,101,113,222,38,196,105,103,226,178,37,11,72,206,58,56,214,77,231,198,21,198,172,100,21,111,73,198,10,211,43,200,222,96,131,228,199,4,251,108,108,205,125,58,177,71,141,47,217,197,234,221,217,180,67,248,71,107,158,58,251,155,95,2,155,96,112,168,159,194,159,79,215,254,147,142,231,160,239,47,190,223,185,88,235,3,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateValueIsTooBigLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateValueIsTooBigLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("3d07178c-8383-408a-b4b0-8af270358f28"),
				Name = "ValueIsTooBig",
				CreatedInPackageId = new Guid("1b20f82a-6797-466b-aac8-7f8b0b6c1da4"),
				CreatedInSchemaUId = new Guid("74d49b78-e0aa-4469-9a52-40cc8d708b0d"),
				ModifiedInSchemaUId = new Guid("74d49b78-e0aa-4469-9a52-40cc8d708b0d")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("74d49b78-e0aa-4469-9a52-40cc8d708b0d"));
		}

		#endregion

	}

	#endregion

}

