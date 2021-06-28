import React, { useState } from 'react'

const RegisterUser = () => {

    const onSubmit = (e) => {
        e.preventDefault()


    }

    const [firstNameText, setFirstNameText] = useState('');
    const [lastNameText, setLastNameText] = useState('');
    const [emailText, setEmailText] = useState('');

    return (
        <form onSubmit={onSubmit}>
            <div className="form-control">
                <label htmlFor="text-talk">First Name</label>
                <input name="text-talk" type="text" value={firstNameText} placeholder="Enter the name of your talk" onChange={(e) => setFirstNameText(e.target.value)} />
            </div>
            <div className="form-control">
                <label htmlFor="text-talk">Last Name</label>
                <input name="text-talk" type="text" value={lastNameText} placeholder="Enter the name of your talk" onChange={(e) => setLastNameText(e.target.value)} />
            </div>
            <div className="form-control">
                <label htmlFor="text-talk">Email</label>
                <input name="text-talk" type="email" value={emailText} placeholder="Enter the name of your talk" onChange={(e) => setEmailText(e.target.value)} />
            </div>

            <input type="submit" value="Confirm registration" />
        </form>
    )
}


export default RegisterUser