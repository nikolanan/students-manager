namespace StudentsManager.Mvc.Services.Cognitive
{
    public static class KeyPhrases
    {
        public static readonly IDictionary<string, HashSet<string>> QuestionMappings =
            new Dictionary<string, HashSet<string>>
            {
                {
                    "What is functional programming?",
                    new HashSet<string>
                    {
                        "building", "software", "composing", "pure", "functions", "side", "effects", "mutable",
                        "immutable", "declarative", "programming", "paradigm"
                    }
                },
                {
                    "What is a service worker?",
                    new HashSet<string>
                    {
                        "script", "browser", "runs", "background", "separate", "web", "page", "features", "sync",
                        "offline"
                    }
                },
                {
                    "What is inheritance ?",
                    new HashSet<string>
                    {
                        "principle", "programming", "class", "inherit", "behavior", "another", "general", "super",
                        "keyword", "prototypal"
                    }
                },
                {
                    "What is a Cookie?",
                    new HashSet<string>
                    {
                        "http", "session", "personalization", "tracking", "data", "web", "server"
                    }
                },
                {
                    "Which of these paradigms important for JavaScript app developers?",
                    new HashSet<string>
                    {
                        "inheritance", "prototypal"
                    }
                },
                {
                    "What is the difference between == and === operators?",
                    new HashSet<string>
                    {
                        "strict", "comparison", "operators"
                    }
                },
                {
                    "What is the purpose of the let keyword?",
                    new HashSet<string>
                    {
                        "block", "scope", "local", "variable"
                    }
                },
                {
                    "What is a pure function?",
                    new HashSet<string>
                    {
                        "no", "side", "effects", "input", "output", "same"
                    }
                },
                {
                    "What is IIFE(Immediately Invoked Function Expression)?",
                    new HashSet<string>
                    {
                        "function", "defined", "runs", "self", "executing" + "anonymous"
                    }
                },
                {
                    "What is prototypal inheritance?",
                    new HashSet<string>
                    {
                        "ability", "access", "object", "properties", "another", "methods", "existing", "constructor",
                        "inherit", "prototype", "reuse", "reference"
                    }
                },
                {
                    "What is promise chaining?",
                    new HashSet<string>
                    {
                        "process", "sequence", "asynchronous", "tasks", "another"
                    }
                },
                {
                    "How to check if a value is an Array?",
                    new HashSet<string>
                    {
                        "Array.isArray(x)"
                    }
                },
                {
                    "What does use strict do?",
                    new HashSet<string>
                    {
                        "help", "avoid", "bugs", "adds", "restrictions", "accessing", "variable", "declared"
                    }
                },
                {
                    "What is asynchronous programming, and why is it important in JavaScript?",
                    new HashSet<string>
                    {
                        "possible", "express", "waiting", "long-running", "actions", "freezing", "program", "during",
                        "blocking", "performance", "implications"
                    }
                },
                {
                    "Could you explain escape() and unescape() functions?",
                    new HashSet<string>
                    {
                        "allows", "converting", "string", "coded", "form", "securely", "transferring", "information",
                        "system", "network"
                    }
                },
                {
                    "How can you import all exports of a file as an object in JavaScript?",
                    new HashSet<string>
                    {
                        "import", "exported", "members", "object", "*", "as", "from", "methods", "variables", "accessed"
                    }
                },
                {
                    "What is the difference between window and document?",
                    new HashSet<string>
                    {
                        "window", "first", "thing", "loaded", "browser", "object", "properties", "document", "inside"
                    }
                },
                {
                    "What is a Polyfill?",
                    new HashSet<string>
                    {
                        "specific", "code", "allow", "functionality", "expect", "browsers", "support", "built"
                    }
                },
                {
                    "When is prototypal inheritance an appropriate choice?",
                    new HashSet<string>
                    {
                        "delegation", "concatenative", "functional", "modules", "provide", "obvious", "compose",
                        "objects", "sources"
                    }
                },
                {
                    "What are the pros and cons of functional programming vs object-oriented programming?",
                    new HashSet<string>
                    {
                        "trouble", "shared", "state", "same", "resources", "simplify", "applications", "side-effects",
                        "maintainability", "immutability"
                    }
                },
                {
                    "What is DOM?",
                    new HashSet<string>
                    {
                        "web", "page", "loaded", "browser", "creates", "document", "object", "model", "HTML",
                        "constructed", "tree", "objects"
                    }
                },
                {
                    "What are the three states of promise?",
                    new HashSet<string>
                    {
                        "pending", "initial", "state", "fulfilled", "indicates", "operation", "completed", "rejected",
                        "error", "thrown"
                    }
                },
                {
                    "What are the methods available on session storage?",
                    new HashSet<string>
                    {
                        "methods", "reading", "writing", "clearing", "data", "setItem", "getItem", "removeItem", "clear"
                    }
                },
                {
                    "Why do you need web storage?",
                    new HashSet<string>
                    {
                        "secure", "large", "data", "stored", "locally", "affecting", "website", "performance",
                        "information", "transferred"
                    }
                },
                {
                    "What is an event delegation?",
                    new HashSet<string>
                    {
                        "technique", "listening", "events", "delegate", "parent", "element", "detect", "changes"
                    }
                },
                {
                    "What are two-way data binding and one-way data flow, and how are they different?",
                    new HashSet<string>
                    {
                        "angular", "fields", "bound", "model", "data", "dynamically", "changes", "single", "source",
                        "react"
                    }
                },
                {
                    "What does “favor object composition over class inheritance” mean?",
                    new HashSet<string>
                    {
                        "avoid", "class", "hierarchies", "tight", "coupling", "code", "flexible", "smaller", "units"
                    }
                },
                {
                    "What is JSON?",
                    new HashSet<string>
                    {
                        "text", "based", "data", "format", "javascript", "object", "syntax", "transmit", "across",
                        "network", "file", ".json", "application/json"
                    }
                },
                {
                    "How do you compare Object and Map?",
                    new HashSet<string>
                    {
                        "both", "keys", "values", "retrieve", "delete", "stored", "key", "ordered", "size", "iterable",
                        "iterated", "prototype", "pairs"
                    }
                },
                {
                    "How can you create an object in JavaScript?",
                    new HashSet<string>
                    {
                        "Object.create(user)"
                    }
                },
                {
                    "What is Callback?",
                    new HashSet<string>
                    {
                        "function", "passed", "another", "function", "argument", "invoked", "inside", "complete",
                        "action"
                    }
                },
                {
                    "What are the pros and cons of monolithic vs microservice architectures?",
                    new HashSet<string>
                    {
                        "higher", "initial", "cost", "monolthic", "perform", "scale", "services", "independent", "each",
                        "code", "level", "bundle", "together"
                    }
                },
                {
                    "What is a closure in JavaScript?",
                    new HashSet<string>
                    {
                        "combination", "function", "lexical", "environment", "declared", "access", "outer", "enclosing",
                        "scope", "chains", "", "", "", ""
                    }
                },
                {
                    "What are modules?",
                    new HashSet<string>
                    {
                        "small", "units", "independent", "reusable", "code", "foundation", "design", "patterns",
                        "export", "object", "literal", "constructor"
                    }
                },
                {
                    "What are the data types supported by JavaScript?",
                    new HashSet<string>
                    {
                        "logical", "operator", "returns", "side", "operand", "null", "undefined", "logical", "or"
                    }
                }
            };
    }
}