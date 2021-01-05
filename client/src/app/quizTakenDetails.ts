import { AnswerDetails } from './answerDetails';

export interface QuizTakenDetails {
    firstName: string,
    lastName: string,
    userId: string,
    answerDetails: AnswerDetails[],
}