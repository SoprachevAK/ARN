class Subcscriber {
    void Start() {
        Interface.onAction += OnAction;
    }

    void OnAction(Param param) {
        //some code
    }
}

class Foo {
    Interface.OnAction(new Param());
}
