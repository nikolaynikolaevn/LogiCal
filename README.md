# LogiCal
Predicate logic calculator

![image](https://user-images.githubusercontent.com/50246663/156104879-fc43ff9d-60d1-4068-a172-8dcc26bf2276.png)

# Parser
Input validation (input characters, white-space strip, missing brackets validation, check bounding, check predicate mismatch, check if proposition), extract proposition and object variables

# UI
-	Show whether an input expression is a proposition or predicate logic, show whether the expression is a tautology, easy comparing of hex values
-	Parse any infix expression by right click context menu

# Propositions
Parsed in prefix notation, shown in infix notation, generate binary tree, truth tables, generate semantic tableau, simplify, DNF prefix and infix, NAND prefix and infix, binary/hex hash values, show if it is a tautology, nandifying

# Predicate logic
Parsed in prefix notation, shown in infix notation, generate binary tree, generate semantic tableau, show if it is a tautology

# Other useful features
-	Exporting graphs and binary trees to PNG
-	Right-click quick parsing
-	Input validation
-	Parser input shortcuts

# Use

| **Supported Input** | **ASCII**            |
|---------------------|----------------------|
| ¬A                  | ~\(A\), NOT\(A\)     |
| A ⇒ B               | >\(A,B\), =>\(A,B\)  |
| A ⇔ B               | =\(A,B\), <=>\(A,B\) |
| A ⋀ B               | &\(A,B\)             |
| A ⋁ B               | \|\(A,B\)            |
| False               | 0                    |
| True                | 1                    |
| A                   | A                    |
| ↑                   | %\(A,B\)             |
| ∀x\.\(F\)           | @x\.\(F\)            |
| ∃x\.\(F\)           | \!x\.\(F\)           |
| P\(x,y\)            | P\(x,y\)             |
