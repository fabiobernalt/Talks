import React, { useState, useEffect } from "react";

const ShowUsers = () => {

    const users = [{
        id: 1,
        firstName: "Fabio",
        lastName: "Bernal",
        email: "123@email.com",
        picture: "url"
    },
    {
        id: 2,
        firstName: "Fabio",
        lastName: "Bernal",
        email: "456@email.com",
        picture: "url"
    }
];

    return (
        <>
            {users.map((user, index ) => (
                <div>
                    <div>{user.firstName}</div>
                    <div>{user.lastName}</div>
                    <div>{user.email}</div>
                    <img src="picture" />
                </div>
            ))}
            </>
    )

};

export default ShowUsers;
