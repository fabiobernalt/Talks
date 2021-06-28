import React, { useState } from 'react'


const AddTalk = () => {

    const [text, setText] = useState('');

    const onSubmit = (e) => {
        e.preventDefault()

        if (!text) {
            alert('Please add a text');
        }

        setText('');
    }

    return (
        <form onSubmit={onSubmit}>
            <div className="form-control">
                <label htmlFor="text-talk">Talk</label>
                <input name="text-talk" type="text" value={text} placeholder="Enter the name of your talk" onChange={(e) => setText(e.target.value)} />
            </div>

            <input type="submit" value="Save talk" />
        </form>
    )
}

export default AddTalk