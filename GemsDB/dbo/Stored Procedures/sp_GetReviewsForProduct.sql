create procedure sp_GetReviewsForProduct
(
@productid int
)
As
select
	ID,
	author,
	stars,
	body,
	ProductId
From
	review
where
	@productid = ProductId