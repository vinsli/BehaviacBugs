/////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Tencent is pleased to support the open source community by making behaviac available.
//
// Copyright (C) 2015 THL A29 Limited, a Tencent company. All rights reserved.
//
// Licensed under the BSD 3-Clause License (the "License"); you may not use this file except in compliance with
// the License. You may obtain a copy of the License at http://opensource.org/licenses/BSD-3-Clause
//
// Unless required by applicable law or agreed to in writing, software distributed under the License is
// distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and limitations under the License.
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////

using behaviac;
#if UNITY_EDITOR || UNITY_STANDALONE_WIN
using System.Runtime.InteropServices;
#endif

public class BehaviacSystem
{
    #region singleon
    private static BehaviacSystem _instance;
    public static BehaviacSystem Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new BehaviacSystem();
            }

            return _instance;
        }
    }
    #endregion

	protected static BehaviacFileManager ms_fileSystem = null;

	public bool Init (string workspaceExportPath, Workspace.EFileFormat fileFormat)
    {
        if (ms_fileSystem == null)
        {
            ms_fileSystem = new BehaviacFileManager();
        }

        {
            //< write log file
            Config.IsLogging = true;
            //behaviac.Config.IsSocketing = false;

            Workspace.Instance.FilePath = workspaceExportPath;
            //behaviac.Workspace.Instance.FileFormat = behaviac.Workspace.EFileFormat.EFF_cs;
            Workspace.Instance.FileFormat = Workspace.EFileFormat.EFF_xml;

            //register names
            // behaviac.Agent.RegisterInstanceName<Zombie>("Zombie");
            //behaviac.Workspace.Instance.ExportMetas("behaviac/workspace/xmlmeta/BattleCityMeta.xml");

            //behaviac.Debug.Log("Behaviac meta data export over.");
            Agent.SetIdMask(0xffffffff);
        }

        return true;
    }

    public void Uninit()
	{
        Workspace.Instance.Cleanup();
	}

}