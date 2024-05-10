### Project Description - Digital Twin of a House

In this project we have modelled a digital twin of a home. Dynamic elements like automatic opening of doors, cabinets and lights have been included. We have included two types of lights in this project, one that switches on/off using a toggle switch and the other switches on/off when we press the letter 'E' on the keyboard. A first-person player controller is also implemented in the project so that the house can be viewd in a first-person view. Overall, 4 main components make up the project, which is the living room, a bedroom, a kitchen with dining room and an open garden. A basic architectural plan was initially developed so that the digital twin of the house can modelled accordingly.

For modelling the exteriors of the house, we have used a package called ProBuilder, which was used to construct the walls and the flooring of the house.
For designing the interiors of the house, an "Apartment Kit" asset package was imported. Using this, we have included multiple assets which suits each room of the house.

For the living room, we have included assets like a sofa, coffee table, cabinets, TV, light, paintings, door mat, wooden flooring and wallpaper. The light switches on and off when clicked on its toggle switch. A `lightOnOff.cs` script has been developed to facilitate the same. 

Coming to the bedroom, assets like bed, computer table, painting, table lamp, wall mirror, wardrobe and lighting have been included. The lights switch on and off when pressing on the letter "E", and a script to automatically open the door is also present.

For the kitchen cum dining room, basic kitchen appliances, like refrigerator, microwave, gas stove is modelled, along with dining table, chairs, and cupboards whose doors automatically open. A script has been included for the same.

Finally, we have an outdoor garden, which consists of a seating area, along with multiple plants to provide a scenic view for the house.

To view the project, a first-person player has been included, which is controlled by a script called the `PlayerController.cs`. This allows the player to move inside the building in the left, right, forward and backward directions. It also has the provision to rotate its head. If shift is pressed down while moving the Player, it moves at an accelerated pace. Basic assets like directional light and main camera are also included within the project. 
