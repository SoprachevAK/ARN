static class Interface {
    public delegate void OnAction(Param param);
    public static event OnAction onAction;

    public static void DoAction(Param param) {
        onAction.Invoke(param);
    }
}
