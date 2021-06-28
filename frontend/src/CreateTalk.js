import React, { useState } from "react";

const CreateTalk = () => {

    const [titleText, setTitleText] = useState("");
    const [numberSeats, setNumberSeats] = useState(0);

    const onSubmit = (e) => {

    }

    return (
        <form onSubmit={onSubmit}>
            <div className="form-control">
                <label htmlFor="title_talk">Title</label>
                <input
                    name="title_talk"
                    type="text"
                    value={titleText}
                    placeholder="Enter the name of your talk"
                    onChange={(e) => setTitleText(e.target.value)}
                    />
            </div>

            <div className="form-control">
                <label htmlFor="number_seats">Number of seats</label>
                <input
                    name="number_seats"
                    type="number"
                    value={numberSeats}
                    placeholder="Enter the number of seats"
                    onChange={(e) => setNumberSeats(e.target.value)}
                    />
            </div>

            <input type="submit" value="Create talk"/>

        </form>
    )

}

export default CreateTalk