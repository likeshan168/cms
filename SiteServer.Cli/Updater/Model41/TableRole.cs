﻿using System.Collections.Generic;
using Newtonsoft.Json;
using SiteServer.CMS.Core;
using SiteServer.CMS.Model;
using SiteServer.Plugin;

namespace SiteServer.Cli.Updater.Model41
{
    public partial class TableRole
    {
        [JsonProperty("roleName")]
        public string RoleName { get; set; }

        [JsonProperty("productIDCollection")]
        public string ProductIdCollection { get; set; }

        [JsonProperty("creatorUserName")]
        public string CreatorUserName { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }
    }

    public partial class TableRole
    {
        public const string OldTableName = "Roles";

        public static readonly string NewTableName = DataProvider.RoleDao.TableName;

        public static readonly List<TableColumn> NewColumns = DataProvider.RoleDao.TableColumns;

        public static readonly Dictionary<string, string> ConvertKeyDict = null;

        public static readonly Dictionary<string, string> ConvertValueDict = null;
    }
}
