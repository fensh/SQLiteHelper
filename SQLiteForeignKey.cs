namespace System.Data.SQLite
{
    public enum OnChangeAction
    {
        NoActiaon,
        Restrict,
        SetNull,
        SetDefault,
        Cascade
    }
    
    public class SQLiteForeignKey
    {
        public string ParentTableName = "";
        public string ParentColumnName = "";
        public OnChangeAction OnDelete = OnChangeAction.NoActiaon;
        public OnChangeAction OnUpdate = OnChangeAction.NoActiaon;

        public SQLiteForeignKey(string parentTable, string parentColumn, OnChangeAction onDeleteAction, OnChangeAction onUpdateAction)
        {
            ParentColumnName = parentColumn;
            ParentTableName = parentTable;
            OnDelete = onDeleteAction;
            OnUpdate = onUpdateAction;
        }

        public SQLiteForeignKey(string parentTable, string parentColumn)
        {
            ParentColumnName = parentColumn;
            ParentTableName = parentTable;
            OnDelete = OnChangeAction.NoActiaon;
            OnUpdate = OnChangeAction.NoActiaon;
        }
    }
}
