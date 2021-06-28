import React, { useState } from "react";

const CreateConvention = () => {
  const [titleText, setTitleText] = useState("");
  const [descriptionText, setDescriptionText] = useState("");

  const onSubmit = (e) => {
    e.preventDefault();

    if(!titleText) {
      alert("Please add a title");
    }

    fetch("https://localhost:44305/api/convention", {
      method: "POST",
      headers: {
        'Content-Type': "application/json"
      },
      body: JSON.stringify({
        title: titleText,
        description: descriptionText
      })
    }).then(res => {
      console.log(res)
      return res.json();
    })

  };

  return (
    <form onSubmit={onSubmit}>
      <div className="form-control">
        <label htmlFor="title_convention">Title</label>
        <input
          name="title_convention"
          type="text"
          value={titleText}
          placeholder="Enter the name of your convention"
          onChange={(e) => setTitleText(e.target.value)}
        />
      </div>

      <div className="form-control">
        <label htmlFor="description_convention">Description</label>
        <textarea
          name="description_convention"
          value={descriptionText}
          onChange={(e) => setDescriptionText(e.target.value)}
        ></textarea>
      </div>

      <input type="submit" value="Create Convention" />
    </form>
  );
};

export default CreateConvention;
