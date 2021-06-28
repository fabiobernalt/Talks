import React, { useState } from "react";

const ShowTalks = () => {


    const talks = [
        {
            id: 1,
            title: "title talk 1",
            seats: 100,
            speaker: "Fabio 1"
        },
        {
            id: 2,
            title: "title talk 2",
            seats: 100,
            speaker: "Fabio 2"
        },
        {
            id: 3,
            title: "title talk 3",
            seats: 100,
            speaker: "Fabio 3"
        },
    ]

    return (
        <div>
            {talks.map((talk, index) => (
                <div key={talk.id}>
                    <h3>
                        {talk.title}
                    </h3>
                    <h4>{talk.speaker}</h4>
                    <span>{talk.seats}</span>
                </div>
            ))}
        </div>
    )
}

export default ShowTalks