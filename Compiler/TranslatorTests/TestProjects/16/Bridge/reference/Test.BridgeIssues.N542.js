Bridge.assembly("TestProject", function ($asm, globals) {
    "use strict";

    Bridge.define("Test.BridgeIssues.N542.Bridge542", {
        $metadata : function () { return {"att":1048577,"a":2,"m":[{"a":2,"isSynthetic":true,"n":".ctor","t":1,"sn":"ctor"},{"a":2,"n":"Test1","is":true,"t":8,"sn":"Test1","rt":System.String},{"a":2,"n":"Test2","is":true,"t":8,"sn":"Test2","rt":System.String}]}; },
        statics: {
            methods: {
                Test1: function () {
                    var blable = "";
                    /* 
                       vBoubli (@"/faaa");
                    */

                    return blable;
                },
                Test2: function () {
                    var blable = "";
                    vBoubli (@"/faaa");

                    return blable;
                }
            }
        }
    });
});
