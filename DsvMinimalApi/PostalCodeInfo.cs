using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;

namespace DsvMinimalApi
{
	[PrimaryKey("d_codigo", "d_asenta", "d_tipo_asenta")]
	public class PostalCodeInfo
	{
		public string ? d_codigo {get; set; }
		public string ? d_asenta {get; set; }
		public string ? d_tipo_asenta {get; set; }
		public string ? D_mnpio {get; set; }
		public string ? d_estado {get; set; }
		public string ? d_ciudad {get; set; }
		public string ? d_CP {get; set; }
		public string ? c_estado {get; set; }
		public string ? c_oficina {get; set; }
		public string ? c_tipo_asenta {get; set; }
		public string ? c_mnpio {get; set; }
		public string ? id_asenta_cpcons {get; set; }
		public string ? d_zona {get; set; }
		public string ? c_cve_ciudad {get; set; }
		public string ? c_CP { get; set; }
	}
}
