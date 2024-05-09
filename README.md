### Project Description - Digital Twin of a House
In this project we have modelled a digital twin of a home. Dynamic elements like automatic opening of doors, cabinets and lights have been included. We have included two types of lights in this project, one switches on/off using a toggle switch, and the other switches on/off when we press the letter 'E' on the keyboard. A first-person player controller is also implemented in the project so that we can view the house in first-person view. Overall, 4 main components make up the project, which is the living room, a bedroom, a kitchen with dining room and an open garden. A basic architectural plan was initially developed so that the digital twin of the house can modelled accordingly.

For modelling the exteriors of the house, we have used a package called ProBuilder, which was used to construct the walls and the flooring of the house.
For designing the interiors of the house, an "Apartment Kit" asset package was imported. Using this, we have included multiple assets which suits each room of the house.

For the living room, we have included assets like a sofa, coffee table, cabinets, TV, light, paintings, door mat, wooden flooring and wallpaper. The light switches on and off when clicked on its toggle switch. A `lightOnOff.cs` script has been developed to facilitate the same. 

Coming to the bedroom, assets like bed, table, wardrobe and lighting have been included. The lights turn on and off when clicked on the letter "E", and a script to automatically open the door is also present.

For the kitchen cum dining room, basic kitchen appliances, like refrigerator, microwave, gas stove is modelled, along with dining table, chairs, and cupboards whose doors automatically open. A script has been included for the same.

Finally, we have an outdoor garden, which consists of a seating area, along with multiple plants to provide a scenic view for the house.

To view the project, a first-person player has been included, which is controlled by a script called the `PlayerController.cs`. This allows the player to move left, right, forward and backward, and it also has provision to rotate its head. Basic assets like directional light and main camera are also included within the project. Totally, this project consists of (?) assets.
