This application uses the MVC model and you can see how to make pop-up information show.
The application can have only one admin and many users.
I have implemented the Observer design pattern for the seats so that their status updates in real time in the user terminals.

Problem statement:

A theater wants to have an online sistem for reserving tickets to a play.
Everyday the theater decides which show is going to be played today (there is only one available show/day).
The public can make reservations starting in the morning. They`ll have to pay when they come to the play.
The list of seats is memorized in a database. For a seat we have: position in room, seat number and price.
The users can see all the seats in a room (whether it is reserved or not), mentioning the following for every seat:
position, number, price and status (available/taken). Using this application an user can fill in his name and address,
can select multiple seats and after that he can click a button to finalize the reservation.
The user cannot reserve seats with status taken. After a successful reservation all the user terminals will synchronise the information.
The administration terminal should contain a list of shows, the posibility to select the show of the day. CRUD for a show.
Also the admin should be able to set different prices for seats.

The user and password for the admin terminal: admin/admin