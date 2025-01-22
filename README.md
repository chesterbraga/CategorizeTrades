Question 2: A new category was created called PEP (politically exposed person). Also, a new bool property 
IsPoliticallyExposed was created in the ITrade interface. A trade shall be categorized as PEP if 
IsPoliticallyExposed is true. Describe in at most 1 paragraph what you must do in your design to account for this 
new category

R: Create a concrete class "PEPRisk" with its respective business rule.
