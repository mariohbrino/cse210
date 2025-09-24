## Youtube Videos

This app is designed to define videos and comments, were comments have a relationships with videos.
Each videos has many comments that can be counted and listed, the class videos allows to add and
get comments from its internal list of comments.

> Below it's defined the diagram of the classes Comment and Video with it's necessary properties
and methods.

Comment
- personName: string
- message: string
---------------------------
* GetPersonName(): string
* GetMessage(): string

Video
- title: string
- author: string
- lengthSeconds: int
- comments: List<Comment>
---------------------------
* GetComments(): List<Comment>
* SetComment(): void
* GetTitle(): string
* GetAuthor(): string
* GetLengthSeconds(): int
* GetNumberOfComments(): int

## Online Orders

This app is designed to define address, customer, order, and product with a more deep relationship
that allows to define orders for a customer and print the orders items with its costs. Along the
feature to display the shipping label, order items, and order costs.

Below it's defined the diagram of the classes Address, Customer, Order, and Product with it's
necessary properties and methods.

Address
- streetAddress: string
- city: string
- stateOrProvince: string
- country: string
---------------------------
* GetStreetAddress(): string
* GetCity(): string
* GetStateOrProvince(): string
* GetCountry(): string
* IsLocatedOnUSA(): bool
* GetFullAddress(): string

Customer
- name: string
- address: Address
---------------------------
* GetName(): string
* GetAddress(): Address
* IsCustomerLocatedOnUSA(): bool

Order
- customer: Customer
- products: List<Product>
---------------------------
* GetCustomer(): Customer
* SetProduct(): void
* GetProducts(): List<Product>>
* GetPackingLabel(): string
* GetShippingLabel(): string
* GetTotalAmount(): double
* GetOrderCosts(): string

Product
- productId: int
- name: string
- price: double
- quantity: int
---------------------------
* GetProductId(): int
* GetName(): string
* GetQuantity(): int
* GetPrice(): double
* TotalCost(): double
