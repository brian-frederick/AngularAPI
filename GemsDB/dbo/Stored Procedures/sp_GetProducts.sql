CREATE procedure sp_GetProducts As

select
	id, 
	name,
	price,
	[description],
	soldOut,
	canpurchase,
	[Image]
	
From
	Product