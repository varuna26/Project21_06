using System;
using System.Collections.Generic;
using System.Text;

namespace SpecflowFirst
{
    public enum ModuleEnum
    {
        Workspace,
        Permitting,
        Licensing,
        LandManagement,
        Contacts
    }

    public enum FrameNameEnum
    {
        
        FRMLAND,
        FRMLICENSE,
        FRMPERMIT
    }

    public enum ActionType
    {
        Add,
        Edit,
        Delete,
        Save
    }

    public enum PaneTypeEnum
    {
        Inspections,
        Contacts,
        FinancialInformation,
        Chronology,
        Reviews,
        Permitting

    }
}
