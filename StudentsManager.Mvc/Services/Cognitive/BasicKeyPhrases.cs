namespace StudentsManager.Mvc.Services.Cognitive
{
    public class BasicKeyPhrases
    {
        public static readonly IDictionary<string, HashSet<string>> QuestionMappings =
            new Dictionary<string, HashSet<string>>
            {
                {
                    "What are global variables?",
                    new HashSet<string>
                    {
                        "available", "throughout", "length", "code", "no", "scope", "var", "keyword", "local",
                        "variable", "declared"
                    }
                },
                {
                    "What is a prototype chain?",
                    new HashSet<string>
                    {
                        "new ", "types", "object", "existing", "instance", "getPrototypeOf", "objects", "inheritance"
                    }
                },
                {
                    "What are lambda or arrow functions?",
                    new HashSet<string>
                    {
                        "function", "expression", "this", "super", "non-method"
                    }
                },
                {
                    "What is a prompt box?",
                    new HashSet<string>
                    {
                        "allows", "user", "enter", "input", "providing", "text", "box"
                    }
                },
                {
                    "How you can submit a form using JavaScript?",
                    new HashSet<string>
                    {
                        "document.form[0].submit();"
                    }
                },
                {
                    "What's the difference between undefined and not defined in JavaScript?",
                    new HashSet<string>
                    {
                        "variable", "exist", "declared", "throw", "error", "stop", "executing", "typeof"
                    }
                },
                {
                    "What is a scope and how many are there?",
                    new HashSet<string>
                    {
                        "determines", "object", "function", "variable", "accessed", "section", "code"
                    }
                },
                {
                    "What is IIFE(Immediately Invoked Function Expression)?",
                    new HashSet<string>
                    {
                        "function", "runs", "soon", "defined"
                    }
                },
                {
                    "What is memoization?",
                    new HashSet<string>
                    {
                        "technique", "increase", "performance", "caching", "computed", "results"
                    }
                },
                {
                    "What is an event flow?",
                    new HashSet<string>
                    {
                        "order", "event", "received", "web", "page"
                    }
                },
                {
                    "What is undefined property?",
                    new HashSet<string>
                    {
                        "undefined", "indicates", "variable", "assigned", "value", "declared"
                    }
                },
                {
                    "What is null value?",
                    new HashSet<string>
                    {
                        "represents", "intentional", "absence", "object", "value", "primitive"
                    }
                },
                {
                    "What is eval?",
                    new HashSet<string>
                    {
                        "evaluates", "code", "represented", "string", "expression", "statement"
                    }
                },
                {
                    "What are events?",
                    new HashSet<string>
                    {
                        "events", "HTML", "elements", "react"
                    }
                },
                {
                    "What is a promise?",
                    new HashSet<string>
                    {
                        "object", "produce", "value", "future", "resolved", "error", "fulfilled", "rejected", "pending"
                    }
                },
                {
                    "What is Minification?",
                    new HashSet<string>
                    {
                        "removing", "unnecessary", "characters", "empty", "spaces", "removed", "variables", "renamed",
                        "obfuscation"
                    }
                },
                {
                    "What is an enum?",
                    new HashSet<string>
                    {
                        "restricting", "variables", "predefined", "set", "constants"
                    }
                },
                {
                    "How do you add an element at the beginning of an array?",
                    new HashSet<string>
                    {
                        "unshift", "spread", "operator"
                    }
                },
                {
                    "What is the use of preventDefault method?",
                    new HashSet<string>
                    {
                        "cancels", "event", "cancelable", "default", "action", "behaviour", "occur"
                    }
                },
                {
                    "What is BOM?",
                    new HashSet<string>
                    {
                        "Browser", "Object", "Model", "navigator", "objects", "history", "screen", "location",
                        "document", "window", "", "", "", "", "", "", "", "", "", "", "", "", "", ""
                    }
                },
                {
                    "What is the use of setTimeout?",
                    new HashSet<string>
                    {
                        "method", "function", "evaluate", "expression", "specified", "milliseconds"
                    }
                },
                {
                    "How do you detect a mobile browser?",
                    new HashSet<string>
                    {
                        "running", "through", "list", "devices", "match", "useragent", "navigator", "userAgent"
                    }
                },
                {
                    "What are the properties used to get size of window?",
                    new HashSet<string>
                    {
                        "use", "innerWidth", "innerHeight", "clientWidth", "clientHeight", "properties", "window",
                        "document", "element", "body", "objects"
                    }
                },
                {
                    "What is a freeze method?",
                    new HashSet<string>
                    {
                        "freeze", "object", "freezing", "not", "allow", "properties", "prevents", "removing",
                        "prevents", "changing", "enumerability", "configurability", "writability"
                    }
                },
                {
                    "How do you detect javascript disabled in the page",
                    new HashSet<string>
                    {
                        "use", "<noscript>", "tag", "code", "block", "executed", "javascript", "disabled",
                        "alternative", "content", "", "", "", "", "", ""
                    }
                },
                {
                    "Explain passed by value and passed by reference:",
                    new HashSet<string>
                    {
                        "primitive", "data", "types", "passed", "value", "non-primitive", "reference"
                    }
                },
                {
                    "How do you access history in javascript?",
                    new HashSet<string>
                    {
                        "window", "history", "object", "contains", "browser", "load", "previous", "next", "url",
                        "back()", "next()", "methods"
                    }
                },
                {
                    "What are Progressive web applications?",
                    new HashSet<string>
                    {
                        "mobile", "app", "delivered", "through", "web", "built", "common", "technologies", "html",
                        "css", "js", "javascript", "servers", "accessible", "indexed", "search"
                    }
                },
                {
                    "How do you add a key value pair in javascript?",
                    new HashSet<string>
                    {
                        "dot", "notation", "useful", "name", "property", "square", "bracket", "notation", "dynamically"
                    }
                },
                {
                    "What is an error object?",
                    new HashSet<string>
                    {
                        "error", "object", "provides", "information", "occurs", "properties", "name", "message"
                    }
                },
                {
                    "What is an Iterator?",
                    new HashSet<string>
                    {
                        "object", "defines", "sequence", "return", "value", "termination", "protocol", "next()",
                        "method", "value", "done "
                    }
                },
                {
                    "What is the purpose of compareFunction while sorting arrays?",
                    new HashSet<string>
                    {
                        "compareFunction", "define", "sort", "order", "omitted", "array", "converted", "strings",
                        "according"
                    }
                },
                {
                    "How do you find min value in an array?",
                    new HashSet<string>
                    {
                        "Math.min()"
                    }
                }
            };
    }
}