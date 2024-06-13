import { ErrorMessage, Form, Formik } from "formik";
import { observer } from "mobx-react-lite";
import { Button, Header, Label } from "semantic-ui-react";
import MyTextInput from "../../app/common/form/MyTextInput";
import { useStore } from "../../app/stores/store";
import { useNavigate } from "react-router-dom";

export default observer(function LoginForm() {
    const { userStore } = useStore();
    const navigate = useNavigate();

    return (
        <Formik
            initialValues={{ email: '', password: '', error: null }}
            onSubmit={async (values, { setErrors }) =>{
                try{
                    await userStore.login(values);
                    navigate("/games-time");
                }catch (error){
                    setErrors({ error: 'Email ou senha invalida' })
                }
            }}
        >
            {({ handleSubmit, isSubmitting, errors }) => (
                <Form className='ui form' onSubmit={handleSubmit} autoComplete='off'>
                    <Header as='h2' content='Login' color="teal" textAlign="center" />
                    <MyTextInput placeholder="Email" name='email' />
                    <MyTextInput placeholder="Senha" name='password' type='password' />
                    <ErrorMessage name='error' render={() => 
                        <Label style={{ marginBottom: 10 }} basic color='red' content={errors.error} />} />
                    <Button loading={isSubmitting} positive content='Login' type="submit" fluid />
                </Form>
            )}

        </Formik>
    )
})